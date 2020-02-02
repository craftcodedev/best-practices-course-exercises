using System;

namespace Factory.SimpleFactory
{
    public abstract class Car
    {
        public void BuyCar(string brand)
        {
            Console.WriteLine(brand + " bought"); 
        }
    }
}
