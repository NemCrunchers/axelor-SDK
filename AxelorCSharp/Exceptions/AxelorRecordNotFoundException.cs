using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK.Exceptions
{
	class AxelorRecordNotFoundException : System.Exception
	{
        public AxelorRecordNotFoundException(Type type, long id): base($"{type.ToString()} with id {id} could not be found") { }
    }
}
