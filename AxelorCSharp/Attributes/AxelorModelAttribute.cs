using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axelor.SDK
{
    using System;
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ModelAttribute : Attribute
    {
        private string model;
        public ModelAttribute(string model)
        {
            this.model = model;
        }
        public string ModelName
        {
            get { return model; }
        }
    }
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class FieldAttribute : Attribute
    {
        private string field;
        public FieldAttribute(string field)
        {
            this.field = field;
        }
        public string FieldName
        {
            get { return field; }
        }
    }
}

