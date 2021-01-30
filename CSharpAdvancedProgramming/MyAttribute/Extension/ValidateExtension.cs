using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace MyAttribute.Extension
{
    public static class ValidateExtension
    {
        public static bool Validate(this object obj)
        {
            Type type = obj.GetType();
            //检查type的每一个attribute
            foreach (var prop in type.GetProperties())
            {
                //找到LongAttribute这个特效
                if (prop.IsDefined(typeof(LongAttribute), true))
                {
                    LongAttribute attribute = (LongAttribute)prop.GetCustomAttribute(typeof(LongAttribute), true);
                    if (!attribute.Validate(prop.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }
}
