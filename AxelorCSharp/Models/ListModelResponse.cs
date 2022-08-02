using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Models
{
    public class ListModelResponse
    {
        public int status;
        public int offset;
        public int total;
        public List<JObject> data;
    }
}
