using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Models
{
    public class StatusResponse
    {
        public RequestStatus status;


        public enum RequestStatus
        {
            Error = -1,
            OK = 0,
        }
    }
}
