using System;

namespace Decorator
{
    class EuropeStyle : House
    {
        private House _house;//将可能需要的一些别的类的定义在自己的类中，
        public override void Show()
        {
            Console.WriteLine("这是欧式风格");
            if (_house != null)
                _house.Show();
        }

        public void AddStyle(House house)
        {
            this._house = house;
        }
    }
}
