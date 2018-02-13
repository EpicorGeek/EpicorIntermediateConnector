using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RESTDotNet
{
    public partial class ExampleCustomerREST
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
            return GenericRequest(Method.GET, "Erp.BO.CustomerSvc",
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
            return GenericRequest(Method.GET, "Erp.BO.CustomerSvc", $"Customers({company}, {custNum})");
        }

        /// <summary>
        /// OData-specific rules:OData $-parameters data are case-sensitiveString parameters should be specified in single quotes
        /// </summary>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public string GetRows(string whereClause = "")
        {
            whereClause = whereClause.StartsWith("?$") ? whereClause : "?$" + whereClause;

            return GenericRequest(Method.GET, "Erp.BO.CustomerSvc",
                $"Customers{whereClause}");
        }

        public string GetList(string whereClause = "")
        {
            whereClause = whereClause.StartsWith("?$") ? whereClause : "?$" + whereClause;

            return GenericRequest(Method.GET, "Erp.BO.CustomerSvc",
                $"List{whereClause}");
        }

        public string Update(string companyId, int custNum, IEnumerable<(string field, string value)> modifiedFields)
        {
            var jParam = $@"{{ ""CustNum"" : {custNum}";

            jParam = modifiedFields.Aggregate(jParam, (current, modifiedField) => current + $@", ""{modifiedField.field}"": ""{modifiedField.value}"" ");
            jParam += "}";


            var paramList = new List<(string name, string value)>
            {
                ("application/json", jParam)
            };
           
            return GenericRequest(Method.PATCH, "Erp.BO.CustomerSvc", $"Customers('{companyId}',{custNum})", paramList);
        }

        public string GetNewCustomer(string companyId, IEnumerable<(string field, string value)> customerFields)
        {
            var jParam = $@"{{ ""Company"" : ""{companyId}""";

            jParam = customerFields.Aggregate(jParam, (current, customerField) => current + $@", ""{customerField.field}"": ""{customerField.value}"" ");      
            jParam += "}";


            var paramList = new List<(string name, string value)>
            {
                ("application/json", jParam)
            };

            return GenericRequest(Method.POST, "Erp.BO.CustomerSvc", $"Customers", paramList);            
        }

        public string DeleteCustomer(string companyId, int custNum)
        {
            return GenericRequest(Method.DELETE, "Erp.BO.CustomerSvc", $"Customers('{companyId}',{custNum})");
        }
    }
}
