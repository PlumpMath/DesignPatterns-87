using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 加法操作
    /// </summary>
    class Add:Operat
    {
        public Add() { }

        public Add(double numberA,double numberB) { }

        public override double GetResult()
        {
            return NumberB + NumberA;
        }
    }
}
