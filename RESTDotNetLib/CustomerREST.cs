using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsEpicorAPI;

namespace EpicorRestApi
{
    public partial class CustomerREST
    {
        public RESTAPI epicorRestApi { get; }

        public string LastUrlRequested => epicorRestApi.LastUrlRequested;

        public CustomerREST(RESTAPI.EpicorConnectionInfo conInfo)
        {
            epicorRestApi = new RESTAPI(conInfo);
        }
    }
}
