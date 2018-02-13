using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RESTDotNet
{
    public partial class ExampleCustomerREST
    {
        public struct EpicorConnectionInfo
        {
            //Epicor Login Credentials
            public string EpicorUsername { get; set; }
            public string EpicorPassword { get; set; }

            //URL to Access
            public string EpicorServer { get; set; }
            public string EpicorApplicationName { get; set; }
        }

        

        public string LastUrlRequested { get; private set; }

        private EpicorConnectionInfo _conInfo;

        /// <summary>
        /// template to form URL
        /// {0} => EpicorServer
        /// {1} => EpicorApplicationName
        /// {2} => EpicorObject
        /// {3} => EpicorObjectMethod
        /// </summary>
        private const string _ttUrl = @"https://{0}/{1}/api/v1/{2}/{3}";

        /// <summary>
        /// Make use of ttUrl to create a valid string to be used in the RestClient initialization
        /// </summary>
        /// <param name="epicorObject"></param>
        /// <param name="epicorObjectMethod"></param>
        /// <returns></returns>
        private string Url(string epicorObject, string epicorObjectMethod)
        {
            return string.Format(_ttUrl,
                _conInfo.EpicorServer,
                _conInfo.EpicorApplicationName,
                epicorObject,
                epicorObjectMethod);
        }

        private string GenericRequest(Method mType, string epicorObject, string epicorMethod,
            IEnumerable<(string name, string value)> paramList = null)
        {
            try
            {
                LastUrlRequested = Url(epicorObject, epicorMethod);
                var rClient = new RestClient(LastUrlRequested);
                var request = new RestRequest(mType);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("authorization",
                    $"Basic {Convert.ToBase64String(Encoding.Default.GetBytes($"{_conInfo.EpicorUsername}:{_conInfo.EpicorPassword}"))}");

                if (paramList?.Count() > 0)
                {
                    request.AddHeader("content-type", "application/json");

                    foreach (var parameter in paramList ?? new List<(string name, string value)>())
                        request.AddParameter(parameter.name, parameter.value, ParameterType.RequestBody);
                }

                var response = rClient.Execute(request);

                return response.Content;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Constructor
        public ExampleCustomerREST(EpicorConnectionInfo conInfo)
        {
            this._conInfo = conInfo;

            //Allows calls to a self certificated application
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

    }
}
