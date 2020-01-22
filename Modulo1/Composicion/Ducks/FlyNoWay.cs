using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class FlyNoWay : IFlybehaviour
    {
        public FlyNoWay()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I can´t fly");
        }
    }
}
