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
                new RedheadDuck()
            };

            foreach (var duck in listDucks)
            {
                duck.Quack();
                duck.Swim();
            }
        }
    }
}
