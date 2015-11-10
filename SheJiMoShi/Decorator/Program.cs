using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 什么是装饰模式：动态的给一个对象添加一些额外的职责。
    /// 用法：有一个类A实现了一个接口Ia，可以将一个类B实现了接口Ib，同时定义一个AddAAbout方法和Ia属性，用该方法接收一个实现了接口Ia的类，然后在类B内 调用A的方法或者属性。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            House _house=new LouFang();
            ChinaStyle chinaStyle=new ChinaStyle();
            chinaStyle.AddStyle(_house);
            chinaStyle.Show();
            Console.ReadKey();
        }
    }
}
