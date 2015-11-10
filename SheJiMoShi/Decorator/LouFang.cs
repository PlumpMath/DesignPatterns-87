using System;

namespace Decorator
{
    class LouFang : House
    {
        public override void Show()
        {
            Console.WriteLine("这是楼房");
        }
    }
}
