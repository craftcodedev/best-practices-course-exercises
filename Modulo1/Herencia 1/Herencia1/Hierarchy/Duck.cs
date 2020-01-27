using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo1.Hierarchy
{
    public abstract class Duck
    {
        public Duck()
        {
        }

        public void Quack()
        {
            Console.WriteLine("I´m quacking");
        }

        public void Swim()
        {
            Console.WriteLine("I´m swimming");
        }

        public abstract void Display();
    }
}
