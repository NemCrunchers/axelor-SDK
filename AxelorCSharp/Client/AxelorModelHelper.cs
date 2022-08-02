using Axelor.SDK.Exceptions;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Axelor.SDK
{
    public static class AxelorModelHelper
    {

        public static string VerifyTypeAndGetModelName(Type type)
        {
            // Must be assignable to AxelorModel
            if (typeof(AxelorModel).IsAssignableFrom(type) == false)
            {
                throw new NotAxelorModelException(type);
            }
            // Must contain a axelor model attribute
            string? modelName = ((ModelAttribute)Attribute.GetCustomAttributes(type).Where(t => t is ModelAttribute).First())?.ModelName;
            if (modelName == null)
            {
                throw new MissingModelAttributeException(type);
            }
            return modelName;
        }
        public static TObject Cast<TObject>(JObject JObject)
        {
            Type ModelType = typeof(TObject);
            string ModelName = VerifyTypeAndGetModelName(ModelType);
            TObject returnObject = (TObject)Activator.CreateInstance(ModelType);

            var targetModelFields = ModelType.GetFields();
            // Go through all bound target object type properties...
            foreach (FieldInfo field in targetModelFields)
            {
                IEnumerable<Attribute> attributes = field.GetCustomAttributes(typeof(FieldAttribute));
                if (attributes.Any())
                {
                    FieldAttribute fieldAttr = (FieldAttribute)attributes.First();
                    Type? fieldType = GetFieldType(field);
                    var value = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(JObject[fieldAttr.FieldName]), fieldType);
                    field.SetValue(returnObject, value);
                }
            }

            return returnObject;
        }

        private static Type GetFieldType(FieldInfo field)
        {
            Type fieldType = field.GetType();
            if (Nullable.GetUnderlyingType(fieldType) != null)
            {
                fieldType = Nullable.GetUnderlyingType(fieldType);
            }
            return fieldType;
        }
    }
}
