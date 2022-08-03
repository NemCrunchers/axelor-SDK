using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Models
{
    [Serializable]
    public class CreateModelRequest
    {
        [JsonProperty]
        public AxelorModel data;
    }
}
