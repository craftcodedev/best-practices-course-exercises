using System;
using System.Collections.Generic;
using Modulo1.Hierarchy;

namespace Modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> listDucks = new List<Duck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };

            foreach (var duck in listDucks)
            {
                duck.Quack();
                duck.Fly();
                duck.Swim();
            }
        }
    }
}
