using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public abstract class Duck
    {
        private IFlybehaviour fb;

        public Duck()
        {
                
        }

        public virtual void Quack()
        {
            Console.WriteLine("I´m quacking");
        }

        public void Swim()
        {
            Console.WriteLine("I´m swimming");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I´m flying");
        }

        public void SetFly(IFlybehaviour fb)
        {
            this.fb = fb;
        }

        public abstract void Display();
    }
}
