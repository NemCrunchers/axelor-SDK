using Axelor.SDK.Exceptions;
using Axelor.SDK.Models;
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
        public static TObject Cast<TObject>(JObject JObject) where TObject : AxelorModel
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
                    var value = JsonConvert.DeserializeObject(JsonConvert.SerializeObject(JObject[fieldAttr.FieldName]), field.FieldType);
                    field.SetValue(returnObject, value);
                }
            }

            return returnObject;
        }
        public static async Task<object> MethodResultAsync(object raw)
        {
            Task returnTask = raw as Task;
            await returnTask;
            var resultProperty = raw.GetType().GetProperty("Result");
            return resultProperty.GetValue(raw);
        }
        public static object GetField(object input, string field)
        {
            var fieldInfo = input.GetType().GetField(field);
            return fieldInfo.GetValue(input);
        }
        public static TObject FillRequiredFields<TObject>(TObject ObjectToFill) where TObject : AxelorModel
        {
            Type ModelType = typeof(TObject);
            string ModelName = VerifyTypeAndGetModelName(ModelType);

            var targetModelFields = ModelType.GetFields();
            // Go through all bound target object type properties...
            foreach (FieldInfo field in targetModelFields)
            {
                IEnumerable<Attribute> attributes = field.GetCustomAttributes(typeof(FieldAttribute));
                if (attributes.Any())
                {
                    FieldAttribute fieldAttr = (FieldAttribute)attributes.First();
                    Type? fieldType = GetFieldType(field);
                    if (fieldAttr.Required)
                    {
                        object valueToAssign = null;
                        if (fieldAttr.DefaultValue != null)
                        {
                            if (fieldType == typeof(string))
                            {
                                valueToAssign = fieldAttr.DefaultValue;
                            }
                            else
                            {
                                valueToAssign = Convert.ChangeType(fieldAttr.DefaultValue, fieldType);
                            }
                        }
                        else if(fieldType == typeof(string))
                        {
                            string unique = Guid.NewGuid().ToString();
                            valueToAssign = unique.Substring(0, Math.Min(unique.Length, fieldAttr.MaxSize));
                        }
                        else if (fieldType == typeof(bool))
                        {
                            valueToAssign = false;
                        }
                        else if (fieldType == typeof(DateTime))
                        {
                            valueToAssign = DateTime.Now;
                        }
                        else if (fieldType == typeof(int) || fieldType == typeof(long))
                        {
                            Random rnd = new Random();
                            valueToAssign = rnd.Next(System.Int32.MinValue, System.Int32.MaxValue);
                        }
                        else if (fieldType.IsAssignableTo(typeof(AxelorModel)))
                        {
                            MethodInfo fillObject = typeof(AxelorModelHelper).GetMethod("FillRequiredFields").MakeGenericMethod(fieldType);

                            object filledObject = fillObject.Invoke(null, new object[1] { Activator.CreateInstance(fieldType) });
                            valueToAssign = filledObject;
                        }
                        else if (fieldType.IsAssignableTo(typeof(IEnumerable<AxelorModel>)))
                        {
                            valueToAssign = Activator.CreateInstance(typeof(List<>).MakeGenericType(fieldType.GenericTypeArguments));
                        }
                        field.SetValue(ObjectToFill, valueToAssign);
                    }
                }
            }

            return ObjectToFill;
        }

        public static void CheckResponseForErrors(string rawContent)
        {
            StatusResponse statusResponse = JsonConvert.DeserializeObject<StatusResponse>(rawContent);
            if (statusResponse.status == StatusResponse.RequestStatus.Error)
            {
                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(rawContent);
                if (errorResponse.data.title == "Internal Server Error")
                {
                    throw new AxelorInternalServerErrorException(errorResponse.data.message);
                }
                throw new AxelorRequestException(errorResponse.data.message);
            }
        }
        private static Type GetFieldType(FieldInfo field)
        {
            Type fieldType = field.FieldType;
            if (Nullable.GetUnderlyingType(fieldType) != null)
            {
                fieldType = Nullable.GetUnderlyingType(fieldType);
            }
            return fieldType;
        }

    }
}
