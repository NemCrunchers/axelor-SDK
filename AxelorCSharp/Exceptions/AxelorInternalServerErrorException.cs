using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Axelor.SDK.Exceptions
{
    [Serializable]
    class AxelorInternalServerErrorException : AxelorRequestException
    {
        public AxelorInternalServerErrorException() { }
        public AxelorInternalServerErrorException(string message) : base(message) { }
    }
}
