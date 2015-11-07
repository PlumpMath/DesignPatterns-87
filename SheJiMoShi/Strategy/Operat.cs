using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 抽象操作类
    /// </summary>
   abstract class Operat
    {
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        /// <summary>
        /// 虚方法，获取结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            return 0;
        }
    }
}
