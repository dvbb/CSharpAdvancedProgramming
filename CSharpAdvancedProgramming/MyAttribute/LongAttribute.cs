using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    public class LongAttribute : Attribute
    {
        private long _Min = 0;
        private long _Max = 0;

        public LongAttribute(long min, long max)
        {
            this._Min = min;
            this._Max = max;
        }

        public bool Validate(object value)
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                //TryParse()方法对value进行转换，若转换成功，结果赋值给IResult
                if (long.TryParse(value.ToString(), out long IResult))
                {
                    if (IResult > this._Min && IResult < this._Max)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
