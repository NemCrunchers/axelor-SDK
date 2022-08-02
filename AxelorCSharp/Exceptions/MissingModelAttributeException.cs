using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Exceptions
{
	class MissingModelAttributeException : System.Exception
	{
        public MissingModelAttributeException(Type type): base($"{type.ToString()} does not have a Model Attribute") { }
    }
}
