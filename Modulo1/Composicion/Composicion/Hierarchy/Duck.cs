using System;
using System.Collections.Generic;
using System.Text;
using Herencia2.Hierarchy;

namespace Modulo1.Hierarchy
{
    public abstract class Duck
    {
        private IFlyBehaviour _fnw;

        public Duck()
        {
        }

        public void SetFlyBehaviour(IFlyBehaviour fnw)
        {
            _fnw = fnw;
        }

        public virtual void Fly()
        {
            _fnw.Fly();
        }

        public virtual void Quack()
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
