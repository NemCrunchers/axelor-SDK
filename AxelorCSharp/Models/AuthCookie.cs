using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Models
{
	public class AuthCookie
    {
        public string JSessionId { get; set; }
        public DateTime Expires { get; set; }
    }
}
