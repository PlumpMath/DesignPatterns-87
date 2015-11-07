using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 抽象类
    /// </summary>
   abstract  class Operat
    {
        /// <summary>
        /// 数A
        /// </summary>
        public double NumberA { get; set; }

        /// <summary>
        /// 数B
        /// </summary>
        public double NumberB { get; set; }

        /// <summary>
        /// 虚方法
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            return 0;
        }
    }
}
