using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Manager.Helper
{
    public static class EnumExtensions
    {
        public static string DisplayName(this Enum value)
        {
            var enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            var member = enumType.GetMember(enumValue)[0];

            var attributes = member.GetCustomAttributes(typeof(DisplayAttribute), false);

            if (attributes == null)
                return enumValue;

            var outString = ((DisplayAttribute)attributes[0]).Name;

            if (((DisplayAttribute)attributes[0]).ResourceType != null)
                outString = ((DisplayAttribute)attributes[0]).GetName();

            return outString;
        }
    }
}
