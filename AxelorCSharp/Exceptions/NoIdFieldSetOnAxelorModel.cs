using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Exceptions
{
	class NoIdFieldSetOnAxelorModel : System.Exception
	{
        public NoIdFieldSetOnAxelorModel(Type type): base($"{type.ToString()} does not have Id field set. Did this object get initialized? ") { }
    }
}
