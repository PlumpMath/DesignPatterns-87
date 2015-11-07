using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 减法操作
    /// </summary>
    class Subtract : Operat
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
