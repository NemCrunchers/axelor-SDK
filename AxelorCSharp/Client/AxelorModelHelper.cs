using Axelor.SDK.Exceptions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axelor.SDK
{
    public static class AxelorModelHelper
    {

        public static string verifyTypeAndGetModelName(Type type)
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
    }
}
