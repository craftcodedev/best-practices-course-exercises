using System;
namespace Herencia2.Hierarchy
{
    public class FlyNoWay : IFlyBehaviour
    {
        public FlyNoWay()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I can´t fly");
        }
    }
}
