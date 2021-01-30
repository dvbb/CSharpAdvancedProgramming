using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    public enum UserState
    {
        [Remark("普通")]
        Normal = 0,
        [Remark("冻结")]
        Frozen = 1,
        Deleted = 2
    }

}
