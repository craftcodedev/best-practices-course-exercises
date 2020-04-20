using System;

namespace Modulo1.Hierarchy
{
    class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I´m a rubber duck");
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
