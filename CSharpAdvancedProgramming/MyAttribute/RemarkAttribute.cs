using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    /// <summary>
    /// 定义了一个attribute，方法体内仅有 字段_Remark 和 GET;SET;
    /// </summary>
    public class RemarkAttribute: Attribute
    {

        private string _Remark = null;

        public RemarkAttribute(string remark)
        {
            this._Remark = remark;
        }

        public string GetRemark()
        {
            return _Remark;
        }
    }
}
