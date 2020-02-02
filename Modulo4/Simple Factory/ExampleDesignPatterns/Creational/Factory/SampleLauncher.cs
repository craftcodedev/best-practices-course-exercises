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
            BMW bmw = new BMW();
            Audi audi = new Audi();

            //Factory simple
            SimpleCarFactory factory = new SimpleCarFactory();
            CarStore store = new CarStore(factory);
            store.BuyCar("Audi");
        }
	}
}
