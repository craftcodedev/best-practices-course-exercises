using Decorator.Models;
using System;

namespace Decorator
{
	public class SampleLauncher
	{
		static void Main(string[] args)
		{
            //Client without decorator
		    var regularOrder = new RegularOrder();
		    Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
		    Console.WriteLine();

		    var preOrder = new PreOrder();
		    Console.WriteLine(preOrder.CalculateTotalOrderPrice());
		    Console.WriteLine();

            //Decorator
            var premiumOrder = new PremiumOrder(preOrder);
            var priceWithDicount = premiumOrder.CalculateOrderPrice();
		}
	}
}
