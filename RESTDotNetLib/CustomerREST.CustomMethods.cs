using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;


namespace EpicorRestApi
{
    public partial class CustomerREST
    {
        /// <summary>
        /// Custom Method: Returns a DataSet given the primary key
        /// The companyID used during the searches is the last one the user used
        /// </summary>
        /// <param name="custNum"></param>
        /// <returns></returns>
        public string GetById(string custNum)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"custNum", custNum}              
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };          

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetByID", paramWrapper);
        }

        /// <summary>
        /// Returns a list of rows that satisfy the where clause.
        /// </summary>
        /// <param name="whereClause"></param>
        /// <param name="pageSize"></param>
        /// <param name="absolutePage"></param>
        /// <returns></returns>
        public string GetList(string whereClause, int pageSize, int absolutePage)
        {

            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"whereClause", whereClause},
                {"pageSize", pageSize},
                {"absolutePage", absolutePage}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetList", paramWrapper);
        }

        /// <summary>
        /// This method finds the customer record by CustId instead of CustNum
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="withShipTo"></param>
        /// <returns></returns>
        public string GetByCustID(string custID, bool withShipTo = true)
        {
                       
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"custID", custID},
                {"withShipTo", withShipTo}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetByCustID", paramWrapper);
        }


        /// <summary>
        /// Inserts a new row in the DataSet with defaults populated
        /// </summary>
        /// <param name="custNum"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        public string GetNewShipTo(int custNum, Dictionary<string, Dictionary<string, object>[]> ds)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"ds", ds},
                {"custNum", custNum}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetNewShipTo", paramWrapper);
        }

        /// <summary>
        /// Inserts a new row in the DataSet with defaults populated
        /// </summary>
        /// <param name="custNum"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        public string GetNewCustBillTo(int custNum, Dictionary<string, Dictionary<string, object>[]> ds)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"ds", ds},
                {"custNum", custNum}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetNewCustBillTo", paramWrapper);
        }


        /// <summary>
        /// Commits the DataSet changes to the data store
        /// </summary>
        /// <param name="custNum"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        public string Update(int custNum, Dictionary<string, Dictionary<string, object>[]> ds)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"ds", ds}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "Update", paramWrapper);
        }       

        /// <summary>
        /// Apply input data to BO by calling GetByID/GetNew/Update methods.
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="continueProcessingOnError"></param>
        /// <param name="rollbackParentOnChildError"></param>
        /// <returns></returns>
        public string UpdateExt(Dictionary<string, Dictionary<string, object>[]> ds, 
            bool continueProcessingOnError = true, bool rollbackParentOnChildError = true)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"ds", ds},
                {"continueProcessingOnError", continueProcessingOnError },
                {"rollbackParentOnChildError", rollbackParentOnChildError }
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)                
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "UpdateExt", paramWrapper);
        }

        /// <summary>
        /// Add customer and customer related tables
        /// </summary>
        /// <param name="company"></param>
        /// <param name="extSystemID"></param>
        /// <param name="transferMethod"></param>
        /// <param name="extCompanyID"></param>
        /// <param name="saveAddOnError"></param>
        /// <param name="imCustomerTableset"></param>
        /// <param name="imIntegrationKey"></param>
        /// <returns></returns>
        public string AddCustomer(string company, string extSystemID, string transferMethod, string extCompanyID,
            bool saveAddOnError, Dictionary<string, Dictionary<string, object>[]> imCustomerTableset,
            Dictionary<string, Dictionary<string, object>[]> imIntegrationKey)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"IMCustomerTableset", imCustomerTableset},
                {"company", company},
                {"extSystemID", extSystemID},
                {"transferMethod", transferMethod},
                {"extCompanyID", extCompanyID},
                {"saveAddOnError", saveAddOnError},
                {"imIntegrationKey", imIntegrationKey}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.IMCustomerSvc", "AddCustomer", paramWrapper);
        }

        /// <summary>
        /// Update customer and customer related tables
        /// </summary>
        /// <param name="company"></param>
        /// <param name="extSystemID"></param>
        /// <param name="transferMethod"></param>
        /// <param name="extCompanyID"></param>
        /// <param name="imCustomerTableset"></param>
        /// <returns></returns>
        public string UpdateCustomer(string company, string extSystemID, string transferMethod, string extCompanyID,
            Dictionary<string, Dictionary<string, object>[]> imCustomerTableset)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"IMCustomerTableset", imCustomerTableset},
                {"company", company},
                {"extSystemID", extSystemID},
                {"transferMethod", transferMethod},
                {"extCompanyID", extCompanyID}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.IMCustomerSvc", "UpdateCustomer", paramWrapper);
        }

        /// <summary>
        /// Generates IntQueOut and IMCustomer rows since the last time this was called and then returns these along with any existing
        /// </summary>
        /// <param name="company"></param>
        /// <param name="extSystemID"></param>
        /// <param name="transferMethod"></param>
        /// <param name="extCompanyID"></param>
        /// <param name="pageSize"></param>
        /// <param name="absolutePage"></param>
        /// <returns></returns>
        public string ImGetAllCustomer(string company, string extSystemID, string transferMethod, string extCompanyID,
            int pageSize, int absolutePage)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {                
                {"company", company},
                {"extSystemID", extSystemID},
                {"transferMethod", transferMethod},
                {"extCompanyID", extCompanyID},
                {"pageSize", pageSize},
                {"absolutePage", absolutePage}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.IMCustomerSvc", "GetAllCustomer", paramWrapper);
        }

        /// <summary>
        /// Generates IntQueOut and IMCustomer rows since the last time this was called and then returns these along with any existing
        /// </summary>
        /// <param name="company"></param>
        /// <param name="extSystemID"></param>
        /// <param name="transferMethod"></param>
        /// <param name="extCompanyID"></param>
        /// <param name="pageSize"></param>
        /// <param name="absolutePage"></param>
        /// <returns></returns>
        public string ImGetCustomer(string company, string extSystemID, string transferMethod, string extCompanyID,
            int pageSize, int absolutePage)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"company", company},
                {"extSystemID", extSystemID},
                {"transferMethod", transferMethod},
                {"extCompanyID", extCompanyID},
                {"pageSize", pageSize},
                {"absolutePage", absolutePage}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.IMCustomerSvc", "GetCustomer", paramWrapper);
        }


        /// <summary>
        /// Acknowledges that passed in IntQueIDs have been received and processed and can be removed from the IntQueOut and IM tables
        /// </summary>
        /// <param name="company"></param>
        /// <param name="extSystemID"></param>
        /// <param name="transferMethod"></param>
        /// <param name="extCompanyID"></param>
        /// <param name="imCustomerTableset"></param>
        /// <returns></returns>         
        public string AckCustomer(string company, string extSystemID, string transferMethod, 
            string extCompanyID, Dictionary<string, Dictionary<string, object>[]> imCustomerTableset)
        {
            var paramList = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"IMCustomerTableset", imCustomerTableset},
                {"company", company},
                {"extSystemID", extSystemID},
                {"transferMethod", transferMethod},
                {"extCompanyID", extCompanyID}
            });

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.IMCustomerSvc", "AckCustomer", paramWrapper);
        }
    }

}