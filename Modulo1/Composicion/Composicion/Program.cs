using System;
using System.Collections.Generic;
using Herencia2.Hierarchy;
using Modulo1.Hierarchy;

namespace Modulo1
{
    class Program
    {
        static void Main(string[] args)
        {

            IFlyBehaviour flyNoWay = new FlyNoWay();
            IFlyBehaviour flyWithWings = new FlyWithWings();
            Duck mallardDuck = new MallardDuck();
            mallardDuck.SetFlyBehaviour(flyWithWings);

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.SetFlyBehaviour(flyWithWings);

            Duck rubberDuck = new RubberDuck();
            rubberDuck.SetFlyBehaviour(flyNoWay);

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.SetFlyBehaviour(flyNoWay);


            List<Duck> listDucks = new List<Duck>
            {
                mallardDuck,
                redheadDuck,
                rubberDuck,
                decoyDuck
            };


            foreach (var duck in listDucks)
            {
                duck.Fly();
            }
        }
    }
}
