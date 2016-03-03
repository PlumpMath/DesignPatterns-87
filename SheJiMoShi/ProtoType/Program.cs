using System;
using System.Runtime.CompilerServices;
using ProtoType.Test1;
using ProtoType.Test2;

namespace ProtoType
{
    /// <summary>
    /// 原型模式;从一个对象创建另一个可以定制的对象，而且不需要知道任何创建的细节
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s=new ConcretePorotype("id");
           var fIdd= ((Test1.ProtoType) s).Idd();//访问父类被隐藏的Idd方法
            var cIdd=s.Idd();//默认访问新类的Idd方法;
            var sClone = s.Clone();
            Console.WriteLine(fIdd);
            Console.WriteLine(cIdd);
            Console.WriteLine(sClone);
            Console.WriteLine("********************************");
            var a=new WorkExperice()
            {
                Name = "testName",
                StarTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7)
            };

            var b = a.Clone();
            Console.WriteLine(b);

            var c=new MyClass();
            var d = c.Clone();
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
