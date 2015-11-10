using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ChinaStyle:House
    {
        private House _house;
        public override void Show()
        {
            Console.WriteLine("这是中式风格");
            if(_house!=null)
                _house.Show();
        }

        public void AddStyle(House house)
        {
            this._house = house;
        }
    }
}
