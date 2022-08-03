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
        private bool required;
        private string defaultValue;
        private int maxSize;
        public FieldAttribute(string field, bool required=false, string defaultValue = null, int maxSize = Int32.MaxValue)
        {
            this.field = field;
            this.required = required;
            this.defaultValue = defaultValue;
            this.maxSize = maxSize;
        }
        public string FieldName
        {
            get { return field; }
        }
        public bool Required
        {
            get { return required; }
        }
        public string DefaultValue
        {
            get { return defaultValue; }
        }
        public int MaxSize
        {
            get { return maxSize; }
        }
    }
}

