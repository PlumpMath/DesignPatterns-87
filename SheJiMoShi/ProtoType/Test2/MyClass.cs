using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Test2
{
    class MyClass:ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
