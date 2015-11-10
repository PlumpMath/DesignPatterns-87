using System;

namespace Proxy
{
    /// <summary>
    /// 什么 是代理模式：本来有一个类A可以直接执行自己的方法就可以实现一个功能，现在先将这个类A作为一个属性传递给一个代理类，代理类通过自己的方法调用A对象的方法，
    /// 同时可以添加一些新功能为其他对象提供一种代理，用来控制对这个对象的访问
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pursuit _pursuit=new Pursuit();
            _pursuit.GiveDolls();

            Proxy _proxy=new Proxy(_pursuit);
            _proxy.GiveDolls();
            Console.ReadKey();
        }
    }
}
