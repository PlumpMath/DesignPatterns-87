using System;

namespace Strategy
{
    /// <summary>
    /// 什么是策略模式？
    /// 策略模式就是在简单工厂模式的基础上，对factory内部同时封装具体的子类的方法实现，
    /// 但是策略模式和工厂模式 还是没从根本上消除switch语句
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Context("+");
            var d = c.GetResult(1, 4);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
