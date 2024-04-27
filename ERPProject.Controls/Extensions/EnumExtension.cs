using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPProject.Controls.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescriptionText(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
                return null;
#pragma warning disable CS8600
            DescriptionAttribute nlitsolutionsDescription = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            return nlitsolutionsDescription?.Description;
#pragma warning restore CS8600
        }
    }
}
