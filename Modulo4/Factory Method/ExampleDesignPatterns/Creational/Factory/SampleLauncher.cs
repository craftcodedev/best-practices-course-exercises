using System;
using Factory.Models;

namespace Factory
{
	class SampleLauncher
	{
		static void Main(string[] args)
		{
            //No Factory
		    Console.WriteLine("No Factory");
		    Console.WriteLine();
            Audi audi = new Audi();
            audi.BuyCar("A3");

            //Simple factory
            SimpleCarFactory carFactory = new SimpleCarFactory();
            CarStore store = new CarStore(carFactory);
            store.BuyCar("Audi", "A3");

            //Factory Method
            CarFactoryMethod audiFactory = new AudiFactory();
            audiFactory.BuyCar("A3");
            CarFactoryMethod bmwFactory = new BMWFactory();
            audiFactory.BuyCar("M3");
        }
	}
}
