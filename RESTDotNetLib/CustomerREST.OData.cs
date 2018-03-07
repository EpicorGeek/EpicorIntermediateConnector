using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace EpicorRestApi
{
    public partial class CustomerREST
    {
        /// <summary>
        /// Not a real GetByID, instead make use of OData protocol
        /// CompanyID is required to simulate the behavior of the GetByID, otherwise this will be a GetRows
        /// </summary>
        /// <param name="company"></param>
        /// <param name="custId"></param>
        /// <returns></returns>
        public string GetById(string company, string custId)
        {
            return epicorRestApi.GenericRequest(Method.GET, "Erp.BO.CustomerSvc",
                $"Customers?$filter=Company eq '{company}' and CustID eq '{custId}'");
        }

        /// <summary>
        /// OData coded GetByID
        /// </summary>
        /// <param name="company"></param>
        /// <param name="custNum"></param>
        /// <returns></returns>
        public string GetById(string company, int custNum)
        {
            return epicorRestApi.GenericRequest(Method.GET, "Erp.BO.CustomerSvc", $"Customers({company}, {custNum})");
        }

        /// <summary>
        /// OData-specific rules:OData $-parameters data are case-sensitiveString parameters should be specified in single quotes
        /// </summary>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public string GetRows(string whereClause = "")
        {
            whereClause = whereClause.StartsWith("?$") ? whereClause : "?$" + whereClause;

            return epicorRestApi.GenericRequest(Method.GET, "Erp.BO.CustomerSvc",
                $"Customers{whereClause}");
        }

        public string GetList(string whereClause = "")
        {
            whereClause = whereClause.StartsWith("?$") ? whereClause : "?$" + whereClause;

            return epicorRestApi.GenericRequest(Method.GET, "Erp.BO.CustomerSvc",
                $"List{whereClause}");
        }

        public string Update(string companyId, int custNum, Dictionary<string, object> modifiedFields)
        {
            var paramList = JsonConvert.SerializeObject(modifiedFields);

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.PATCH, "Erp.BO.CustomerSvc", $"Customers('{companyId}',{custNum})", paramWrapper);
        }

        public string GetNewCustomer(string companyId, Dictionary<string, object> customerFields)
        {
            var paramList = JsonConvert.SerializeObject(customerFields);

            var paramWrapper = new List<(string name, object value)>
            {
                ("application/json", paramList)
            };

            return epicorRestApi.GenericRequest(Method.POST, "Erp.BO.CustomerSvc", $"Customers", paramWrapper);
        }

        public string DeleteCustomer(string companyId, int custNum)
        {
            return epicorRestApi.GenericRequest(Method.DELETE, "Erp.BO.CustomerSvc", $"Customers('{companyId}',{custNum})");
        }
    }
}
