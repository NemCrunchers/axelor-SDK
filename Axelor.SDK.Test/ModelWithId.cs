using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Test
{
    public class ModelWithId
    {
        [JsonProperty("id")]
        public long? Id;
    }
}
