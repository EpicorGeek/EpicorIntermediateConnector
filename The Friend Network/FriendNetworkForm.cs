using System;
using System.Data;
using System.Windows.Forms;
using RESTDotNet;

namespace The_Friend_Network
{
    public partial class FriendNetworkForm : Form
    {
        public FriendNetworkForm()
        {
            InitializeComponent();
            chkInterest.ItemCheck += ChkInterest_ItemCheck;
            
            CreateFriendTable();
            FriendView = new DataView(_friendTable,"", "FriendID", DataViewRowState.CurrentRows);
            AddBindings();

            //Hint: your code for the lstFriendList.SelectedValueChanged should be here
        }
       
        
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNewFriend_Click(object sender, EventArgs e)
        {         
        }



        private void RefreshList()
        {
            
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {            
           
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {


        }


        #region Quick Start Predefined methods

        private const string StatusFixedText = "Last URL requested: ";
        private const string TheFriendNetwork = "The Friend Network";
        private ExampleCustomerREST _customerRestObj;
        private DataTable _friendTable;
        public DataView FriendView;

        public ExampleCustomerREST.EpicorConnectionInfo ConnectionInfo => new ExampleCustomerREST.EpicorConnectionInfo
        {
            EpicorServer = txtApplicationServer.Text,
            EpicorApplicationName = txtApplicationName.Text,
            EpicorUsername = txtEpicorUsr.Text,
            EpicorPassword = txtEpicorPassword.Text
        };

        private void CreateFriendTable()
        {
            _friendTable = new DataTable();

            var colFriendNum = new DataColumn("FriendNum", typeof(int))
            {
                DefaultValue = 0
            };

            var colFriendID = new DataColumn("FriendID", typeof(string))
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

            _friendTable.Columns.Add(colFriendNum);
            _friendTable.Columns.Add(colFriendID);
            _friendTable.Columns.Add(colName);
            _friendTable.Columns.Add(colCity);
            _friendTable.Columns.Add(colCountry);
            _friendTable.Columns.Add(colInterest);

            _friendTable.RowChanged += _friendTable_RowChanged;
        }

        public ExampleCustomerREST CustomerRestObj => _customerRestObj ?? (_customerRestObj = new ExampleCustomerREST(ConnectionInfo));

        private const string fixedFilter = "filter=Company eq '{0}'and PhoneNum eq 'FriendNetwork'{1}&$select=CustNum, Name {2}";

        private string Company;

        private void ModifiedTableIntegrity()
        {
            for (var ix = 0; ix < chkInterest.Items.Count; ++ix)
            {
                chkInterest.SetItemChecked(ix, false);
            }


            txtCustID.Enabled = _friendTable.Rows.Count > 0;
            txtName.Enabled = _friendTable.Rows.Count > 0;
            txtCity.Enabled = _friendTable.Rows.Count > 0;
            txtCountry.Enabled = _friendTable.Rows.Count > 0;
            chkInterest.Enabled = _friendTable.Rows.Count > 0;
            btnUpdateInfo.Enabled = _friendTable.Rows.Count > 0;
            btnRemove.Enabled = _friendTable.Rows.Count > 0;


        }

        private void _friendTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            ModifiedTableIntegrity();
        }

        private void AddBindings()
        {
            txtCustID.DataBindings.Add("Text", FriendView, "FriendID");
            txtName.DataBindings.Add("Text", FriendView, "Name");
            txtCity.DataBindings.Add("Text", FriendView, "City");
            txtCountry.DataBindings.Add("Text", FriendView, "Country");
        }
        private void ChkInterest_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < chkInterest.Items.Count; ++ix)
            {
                if (ix != e.Index) chkInterest.SetItemChecked(ix, false);
            }

            if (FriendView.Table.Rows.Count <= 0) return;

            FriendView[0]["Interest"] = string.Empty;

            if (e.NewValue == CheckState.Checked)
                FriendView[0]["Interest"] = chkInterest.Items[e.Index].ToString();
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
