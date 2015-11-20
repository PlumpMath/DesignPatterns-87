using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Test2
{
    class WorkExperice:ICloneable
    {
        public object Clone()
        {
            return new WorkExperice() {Name = this.Name,StarTime = StarTime,EndTime = EndTime};//深度复制
        }

        public string Name { get; set; }

        public DateTime StarTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
