using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAttribute
{
    public static class RemarkExtension
    {
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetRemark(this Enum value)
        {
            //attribute的使用必须使用反射
            Type type = value.GetType();
            FieldInfo field = type.GetField(value.ToString());
            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                //得到输入参数value的type ， 即为RemarkAttribute
                //然后调用他的get方法，获取到字段_Remark的信息，并返回
                RemarkAttribute attribute = (RemarkAttribute)field.GetCustomAttribute(typeof(RemarkAttribute), true);
                return attribute.GetRemark();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
