using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   abstract class PingFang:House
    {
        public override void Show()
        {
           Console.WriteLine("这是平房");
        }
    }
}
