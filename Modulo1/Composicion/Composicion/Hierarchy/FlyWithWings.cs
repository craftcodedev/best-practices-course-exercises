using System;
namespace Herencia2.Hierarchy
{
    public class FlyWithWings : IFlyBehaviour
    {
        public FlyWithWings()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
