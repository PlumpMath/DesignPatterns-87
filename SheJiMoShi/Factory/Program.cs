using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("****************简单工厂模式***********************");
            Console.WriteLine("数字A:");
            var a = Console.ReadLine();
            Console.WriteLine("数字B:");
            var b = Console.ReadLine();
            Console.WriteLine("加：+，减：-");
            var c = Console.ReadLine();
            var oper = Factory.GetOperat(c);
            oper.NumberA = Convert.ToDouble(a);
            oper.NumberB = Convert.ToDouble(b);
            var d = oper.GetResult();
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
