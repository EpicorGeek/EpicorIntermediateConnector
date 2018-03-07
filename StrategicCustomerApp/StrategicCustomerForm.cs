using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EpicorRestApi;
using StrategicCustomerManagement.Properties;

namespace StrategicCustomerManagement
{
    public partial class StrategicCustomerForm : Form
    {
        public StrategicCustomerForm()
        {
            InitializeComponent();
            chkInterest.ItemCheck += ChkInterest_ItemCheck;
            
            CreateFriendTable();
            CustomerView = new DataView(_customerTable,"", "CustID", DataViewRowState.CurrentRows);
            AddBindings();
            
            //List of customers
            strategicList.SelectedValueChanged += StrategicList_SelectedValueChanged;
            allCustomersList.SelectedValueChanged += AllCustomersList_SelectedValueChanged;

            //Buttons events
            btnTestConnection.Click += btnTestConnection_Click;
            btnRefreshList.Click += btnRefreshList_Click;
            btnRemove.Click += btnRemove_Click;
            btnCustomerAction.Click += btnNewCustomer_Click;
            btnCommitChanges.Click += btnUpdateInfo_Click;
            this.Icon = Resources.star;
        }

        #region UI Control Events
        private void AllCustomersList_SelectedValueChanged(object sender, EventArgs e)
        {
            ListValueChanged(sender as ListBox);
        }

        private void StrategicList_SelectedValueChanged(object sender, EventArgs e)
        {
            ListValueChanged(sender as ListBox);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            _customerRestObj = null;

            var getListResult = CustomerRestObj.GetList("top=1");
            var validConInfo = GenericsEpicorAPI.RESTAPI.IsValidJsonStr(getListResult);

            MessageBox.Show(
                validConInfo ?
                    "Entered server information is correct!" :
                    "Invalid server information", StrategicCustomerManager, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (validConInfo)
            {
                var resultDictionary = JsonConvert.DeserializeAnonymousType(getListResult, new Dictionary<string, object>());

                try
                {
                    resultDictionary = JsonConvert.DeserializeAnonymousType(
                        resultDictionary["value"].ToString()
                            .Substring(1, resultDictionary["value"].ToString().Length - 2),
                        new Dictionary<string, object>());

                    Company = resultDictionary["Company"].ToString();
                }
                catch
                {
                    // ignored
                }
            }

            statusLbl.Text = StatusFixedText + CustomerRestObj.LastUrlRequested;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            _customerTable.Clear();
            _customerTable.Rows.Add();
            NotifyAll();

        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshList(strategicList, strategicCustomersFilter);
            RefreshList(allCustomersList, allCustomersFilter);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Epicor Rest API
            var dltResult = EpicorDeleteImplementation();

            //UI Actions
            MessageBox.Show(dltResult, StrategicCustomerManager, MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList(strategicList, strategicCustomersFilter);
            RefreshList(allCustomersList, allCustomersFilter);
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //Epicor Rest API
            var updtResult = EpicorUpdateImplementation();

            //UI Actions
            MessageBox.Show(updtResult, StrategicCustomerManager, MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshList(strategicList, strategicCustomersFilter);
            RefreshList(allCustomersList, allCustomersFilter);
        }

        #endregion

        #region Epicor REST API Implementation

        private void ListValueChanged(ListBox selectedList)
        {
            var custnum = selectedList?.SelectedItem?.ToString()
                .Substring(0, selectedList.SelectedItem.ToString().IndexOf("~", StringComparison.Ordinal) > 0
                    ? selectedList.SelectedItem.ToString().IndexOf("~", StringComparison.Ordinal)
                    : 0);


            var s = CustomerRestObj.GetList(string.Format(allCustomersFilter, Company, $" and CustNum eq {custnum}",
                ", CustID, City, Country, Zip, PhoneNum"));

            if (!GenericsEpicorAPI.RESTAPI.IsValidJsonStr(s))
                return;

            var resultDictionary = JsonConvert.DeserializeAnonymousType(s, new Dictionary<string, object>());

            if (resultDictionary.ContainsKey("value") && resultDictionary["value"].ToString().Length > 10)
            {
                if (!(resultDictionary["value"] is JArray jArr)) return;

                _customerTable.Clear();
                _customerTable.Rows.Add();


                CustomerView[0]["CustNum"] = jArr.First.Value<string>("CustNum");
                CustomerView[0]["CustID"] = jArr.First.Value<string>("CustID");
                CustomerView[0]["Name"] = jArr.First.Value<string>("Name");
                CustomerView[0]["City"] = jArr.First.Value<string>("City");
                CustomerView[0]["Country"] = jArr.First.Value<string>("Country");
                CustomerView[0]["Interest"] = jArr.First.Value<string>("Zip");
                chkIsStrategicCustomer.Checked =
                    jArr.First.Value<string>("PhoneNum")?.Equals("StrategicCustomer") ?? false;

                if (!string.IsNullOrEmpty(CustomerView[0]["Interest"].ToString()))
                {
                    for (var ix = 0; ix < chkInterest.Items.Count; ++ix)
                    {
                        if (chkInterest.GetItemText(chkInterest.Items[ix]) ==
                            CustomerView[0]["Interest"].ToString())
                            chkInterest.SetItemChecked(ix, true);
                    }
                }

                NotifyAll();
            }

        }

        private string EpicorDeleteImplementation()
        {
            var result = string.Empty;

            if ((int) CustomerView[0]["CustNum"] > 0)
            {
                result = CustomerRestObj.DeleteCustomer("", (int) CustomerView[0]["CustNum"]);
                this.statusLbl.Text = StatusFixedText + CustomerRestObj.LastUrlRequested;
            }




            _customerTable.Clear();
            NotifyAll();
            ModifiedTableIntegrity();

            if (!GenericsEpicorAPI.RESTAPI.IsValidJsonStr(result))
                return result;

            var resultDictionary = JsonConvert.DeserializeAnonymousType(result, new Dictionary<string, object>());

            return resultDictionary?.ContainsKey("ErrorMessage") ?? false
                ? resultDictionary?["ErrorMessage"].ToString()
                : "Delete successful";
        }

        private string EpicorUpdateImplementation()
        {
            var mod = new Dictionary<string, object>
            {
                {"CustID", CustomerView[0]["CustID"]},
                {"Name", CustomerView[0]["Name"]},
                {"City", CustomerView[0]["City"]},
                {"Country", CustomerView[0]["Country"]},
                {"Zip", CustomerView[0]["Interest"]},
                {"PhoneNum",  chkIsStrategicCustomer.Checked ? "StrategicCustomer" : "" }
            };

            var result = (int)CustomerView[0]["CustNum"] == 0 ?
                CustomerRestObj.GetNewCustomer(Company, mod) :  // if it's a Customer: "GetNewCustomer"
                CustomerRestObj.Update(Company, (int)CustomerView[0]["CustNum"], mod); // if we are updating customer information: "Update"

            if (!GenericsEpicorAPI.RESTAPI.IsValidJsonStr(result))
            {
                return string.IsNullOrEmpty(result) ? "Update successful" : result;
            }
                
            var resultDictionary = JsonConvert.DeserializeAnonymousType(result, new Dictionary<string, object>());

            return resultDictionary?.ContainsKey("ErrorMessage") ?? false
                ? resultDictionary?["ErrorMessage"].ToString()
                : "Update successful";
        }

        private void RefreshList(ListBox selectedList, string filter)
        {
            selectedList.Items.Clear();

            var jsonFriendlist = CustomerRestObj.GetList(string.Format(filter, Company, "", ""));
            statusLbl.Text = StatusFixedText + CustomerRestObj.LastUrlRequested;

            if (!GenericsEpicorAPI.RESTAPI.IsValidJsonStr(jsonFriendlist))
                return;

            var resultDictionary = JsonConvert.DeserializeAnonymousType(jsonFriendlist, new Dictionary<string, object>());

            if ((resultDictionary?.ContainsKey("value") ?? false) && resultDictionary?["value"].ToString().Length > 10)
            {
                if (!(resultDictionary["value"] is JArray jArr)) return;

                foreach (var x in jArr)
                {
                    selectedList.Items.Add($"{x.Value<int>("CustNum")}~{x.Value<string>("Name")}");
                }
            }
        }

        #endregion

        #region Quick Start Predefined methods

        private const string StatusFixedText = "Last URL requested: ";
        private const string StrategicCustomerManager = "Strategic Customer Management";
        private CustomerREST _customerRestObj;
        private DataTable _customerTable;
        public DataView CustomerView;

        public GenericsEpicorAPI.RESTAPI.EpicorConnectionInfo ConnectionInfo => new GenericsEpicorAPI.RESTAPI.EpicorConnectionInfo
        {
            EpicorServer = txtApplicationServer.Text,
            EpicorApplicationName = txtApplicationName.Text,
            EpicorUsername = txtEpicorUsr.Text,
            EpicorPassword = txtEpicorPassword.Text
        };

        private void CreateFriendTable()
        {
            
            _customerTable = new DataTable();

            var colCustNum = new DataColumn("CustNum", typeof(int))
            {
                DefaultValue = 0
            };

            var colCustID = new DataColumn("CustID", typeof(string))
            {
                DefaultValue = string.Empty
            };

            var colName = new DataColumn("Name", typeof(string))
            {
                DefaultValue = string.Empty
            };

            var colCity = new DataColumn("City", typeof(string))
            {
                DefaultValue = string.Empty
            };

            var colCountry = new DataColumn("Country", typeof(string))
            {
                DefaultValue = string.Empty
            };


            var colInterest = new DataColumn("Interest", typeof(string))
            {
                DefaultValue = string.Empty
            };

            _customerTable.Columns.Add(colCustNum);
            _customerTable.Columns.Add(colCustID);
            _customerTable.Columns.Add(colName);
            _customerTable.Columns.Add(colCity);
            _customerTable.Columns.Add(colCountry);
            _customerTable.Columns.Add(colInterest);

            _customerTable.RowChanged += CustomerTableRowChanged;
        }

        public CustomerREST CustomerRestObj => _customerRestObj ?? (_customerRestObj = new CustomerREST(ConnectionInfo));

        private const string strategicCustomersFilter = "filter=Company eq '{0}'and PhoneNum eq 'StrategicCustomer'{1}&$select=CustNum, Name {2}";
        private const string allCustomersFilter = "filter=Company eq '{0}'{1}&$select=CustNum, Name {2}";

        private string Company;

        private void ModifiedTableIntegrity()
        {
            for (var ix = 0; ix < chkInterest.Items.Count; ++ix)
            {
                chkInterest.SetItemChecked(ix, false);
            }


            txtCustID.Enabled = _customerTable.Rows.Count > 0;
            txtName.Enabled = _customerTable.Rows.Count > 0;
            txtCity.Enabled = _customerTable.Rows.Count > 0;
            txtCountry.Enabled = _customerTable.Rows.Count > 0;
            chkInterest.Enabled = _customerTable.Rows.Count > 0;
            btnCommitChanges.Enabled = _customerTable.Rows.Count > 0;
            btnRemove.Enabled = _customerTable.Rows.Count > 0;
            chkIsStrategicCustomer.Checked = false;
            chkIsStrategicCustomer.Enabled = _customerTable.Rows.Count > 0;
        }

        private void CustomerTableRowChanged(object sender, DataRowChangeEventArgs e)
        {
            ModifiedTableIntegrity();
        }

        private void AddBindings()
        {
            txtCustID.DataBindings.Add("Text", CustomerView, "CustID");
            txtName.DataBindings.Add("Text", CustomerView, "Name");
            txtCity.DataBindings.Add("Text", CustomerView, "City");
            txtCountry.DataBindings.Add("Text", CustomerView, "Country");
        }
        private void ChkInterest_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < chkInterest.Items.Count; ++ix)
            {
                if (ix != e.Index) chkInterest.SetItemChecked(ix, false);
            }

            if (CustomerView.Table.Rows.Count <= 0) return;

            CustomerView[0]["Interest"] = string.Empty;

            if (e.NewValue == CheckState.Checked)
                CustomerView[0]["Interest"] = chkInterest.Items[e.Index].ToString();
        }

        private void NotifyAll()
        {
            txtCustID.DataBindings[0].ReadValue();
            txtCustID.DataBindings[0].ReadValue();
            txtName.DataBindings[0].ReadValue();
            txtCity.DataBindings[0].ReadValue();
            txtCountry.DataBindings[0].ReadValue();
        }

        #endregion
    }
}
