using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace RESTDotNet
{
    public partial class ExampleCustomerREST
    {
        /// <summary>
        /// Custom Method: Returns a DataSet given the primary key
        /// The companyID used during the searches is the last one the user used
        /// </summary>
        /// <param name="custNum"></param>
        /// <returns></returns>
        public string GetById(string custNum)
        {
            var paramList = new List<(string name, string value)>
            {
                ("application/json", $@"{{
                                        ""custNum"": {custNum}
                                      }}")
            };

            return GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetByID", paramList);
        }

        public string GetList(string whereClause, int pageSize, int absolutePage)
        {
            var paramList = new List<(string name, string value)>
            {
                ("application/json", $@"{{
                                        ""whereClause"": ""{whereClause}"",
                                        ""pageSize"": {pageSize},
                                        ""absolutePage"": {absolutePage},
                                      }}")
            };

            return GenericRequest(Method.POST, "Erp.BO.CustomerSvc", "GetList", paramList);
        }

    }
}
