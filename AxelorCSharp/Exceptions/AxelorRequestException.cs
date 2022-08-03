using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Axelor.SDK.Exceptions
{
    [Serializable]
    class AxelorRequestException : System.Exception
    {
        public AxelorRequestException() { }
        public AxelorRequestException(string message) : base(message) { }
    }
}
