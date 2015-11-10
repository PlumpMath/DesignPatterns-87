using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFactory
{
    /// <summary>
    /// 工厂模式存在类与switch语句的高耦合，增加新类，需要去增加case分支，违背了开放-封闭原则
    /// 工厂方法模式可以解决这个问题
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SubtratctFactory sf=new SubtratctFactory();
            Operator op = sf.CreateOperator();
            op.numberA = 10;
            op.numberB = 5;
            var b=op.GetResult();
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
