using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            单例模式确保一个类只有一个实例，并提供全局访问点，它的使用场景比如任务管理器整个系统中应该只一个，再比如文件操作，同一时间我们只能有一个对象操作文件。最重要的，比如我们项目中用得非常多的功能，日志记录，在一个线程中，记录日志的对象应该也只有一个。
            单例模式的目的是为了保证程序的安全性和数据的唯一性。
            */
        }
    }

    public class Singleton
    {
        //定义一个静态变量来保存类的实例
        private static Singleton uniqueInstance;

        //定义一个标识确保线程同步
        private static readonly object locker=new object();

        //定义私有构造函数，使外界不能创建该类实例
        private Singleton()
        {
            
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点，同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            //双重锁定只需要一句判断就可以了
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    //如果类的实例不存在则创建，否则直接返回
                    if (uniqueInstance == null)
                    {
                        uniqueInstance=new Singleton();
                    }
                }
            }
            return uniqueInstance;
        }


    }
}
