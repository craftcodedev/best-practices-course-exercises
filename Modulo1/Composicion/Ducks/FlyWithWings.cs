using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class FlyWithWings : IFlybehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I´m flying");
        }
    }
}
