using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Models
{
    public class ErrorResponse
    {
        public int status;
        public Data data;

        public class Data
        {
            public bool popup;
            public string title;
            public string message;
        }
    }

}
