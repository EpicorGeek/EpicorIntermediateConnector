using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace GenericsEpicorAPI
{
    public class RESTAPI
    {
        private bool UseBearerToken { get; }


        public struct EpicorConnectionInfo
        {
            //Authorization Information
            public string EpicorUsername { get; set; }
            public string EpicorPassword { get; set; }
            public string BearerToken { get; set; }

            //Access Information
            public string EpicorServer { get; set; }
            public string EpicorApplicationName { get; set; }
        }

        public RESTAPI(EpicorConnectionInfo conInfo, bool useBearerToken = false)
        {
            _conInfo = conInfo;
            UseBearerToken = useBearerToken;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        /// <summary>
        /// Return the last url requested
        /// </summary>
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

        /// <summary>
        /// Generic call 
        /// </summary>
        /// <param name="mType"></param>
        /// <param name="epicorObject"></param>
        /// <param name="epicorMethod"></param>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public string GenericRequest(Method mType, string epicorObject, string epicorMethod,
            IEnumerable<(string name, object value)> paramList = null)
        {
            try
            {
                LastUrlRequested = Url(epicorObject, epicorMethod);
                var rClient = new RestClient(LastUrlRequested);
                var request = new RestRequest(mType);
                request.AddHeader("cache-control", "no-cache");

                request.AddHeader("authorization",
                    UseBearerToken
                        ? $"Bearer {_conInfo.BearerToken}"
                        : $"Basic {Convert.ToBase64String(Encoding.Default.GetBytes($"{_conInfo.EpicorUsername}:{_conInfo.EpicorPassword}"))}");

                if (paramList != null && paramList.Any())
                {
                    request.AddHeader("content-type", "application/json");

                    foreach (var parameter in paramList)
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

        /// <summary>
        /// Validate if the given string is a valid json string
        /// </summary>
        /// <param name="jStr"></param>
        /// <returns></returns>
        public static bool IsValidJsonStr(string jStr)
        {
            try
            {
                JToken.Parse(jStr);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
