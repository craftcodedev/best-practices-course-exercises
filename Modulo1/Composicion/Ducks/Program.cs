using System;
using System.Collections.Generic;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> listDucks = new List<Duck>();

            IFlybehaviour fbNW = new FlyNoWay();
            IFlybehaviour fww = new FlyWithWings();

            MallardDuck md = new MallardDuck();
            md.SetFly(fww);

            RedheadDuck rh = new RedheadDuck();
            rh.SetFly(fww);

            RubberDuck rd = new RubberDuck();
            rd.SetFly(fbNW);

            DecoyDuck dd = new DecoyDuck();
            dd.SetFly(fbNW);

            listDucks.Add(md);
            listDucks.Add(rh);
            listDucks.Add(rd);
            listDucks.Add(dd);

            foreach (var duck in listDucks)
            {
                //duck.Quack();
                duck.Swim();
                duck.Fly();
            }
        }
    }
}
