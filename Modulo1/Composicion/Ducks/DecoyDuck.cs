using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class DecoyDuck : Duck
    {

        public override void Quack()
        {
            throw new Exception();
        }

        public override void Display()
        {
            Console.WriteLine("I´m a decoy duck");
        }
    }
}
