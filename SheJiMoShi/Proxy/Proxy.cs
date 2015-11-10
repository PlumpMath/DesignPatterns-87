using System;

namespace Proxy
{
   public class Proxy:IGiveGift
   {

       private readonly IGiveGift _iGiveGift;

       public Proxy(IGiveGift iGiveGift)
       {
           this._iGiveGift = iGiveGift;
       }

       public void GiveDolls()
       {
          _iGiveGift.GiveDolls();
            Console.WriteLine("Proxy can do some badthing in this lol");
       }

       public void GiveFlowers()
       {
            _iGiveGift.GiveFlowers();
            Console.WriteLine("hello beauty,the flower is min,not his");
       }
    }
}
