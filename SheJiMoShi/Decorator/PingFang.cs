﻿using System;

namespace Decorator
{
    class PingFang : House
    {
        public override void Show()
        {
            Console.WriteLine("这是平房");
        }
    }
}
