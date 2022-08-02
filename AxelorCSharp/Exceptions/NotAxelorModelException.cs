using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Exceptions
{
	class NotAxelorModelException : System.Exception
	{
        public NotAxelorModelException(Type type): base($"{type.ToString()} is not assignable to Axelor.SDK.AxelorModel") { }
    }
}
