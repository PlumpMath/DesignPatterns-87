using System;

namespace Proxy
{
   public class Pursuit:IGiveGift
    {
       public void GiveDolls()
       {
           Console.WriteLine("Give Dolls");
       }

       public void GiveFlowers()
       {
           Console.WriteLine("Give Flowers");
       }
    }
}
