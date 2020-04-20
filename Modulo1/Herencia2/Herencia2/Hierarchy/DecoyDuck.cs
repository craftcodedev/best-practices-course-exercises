using System;

namespace Modulo1.Hierarchy
{
    class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I´m a decoy duck");
        }
  
        public override void Quack()
        {
            throw new Exception("I can't quack");
        }
  
        public override void Fly()
        {
            throw new Exception("I can't fly");
        }
    }
}
