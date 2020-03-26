using System;

namespace Observer
{
	public class SampleLauncher
	{
		static void Main(string[] args)
		{
            Product product = new Product("Dell", 1000);

            Customer customer1 = new Customer("C1");

            Customer customer2 = new Customer("C2");

            product.Subscribe(customer1);
            product.Subscribe(customer2);

            product.Price = 800;

            product.Unsubscribe(customer1);

            Customer customer3 = new Customer("C3");
            product.Subscribe(customer3);

            product.Price = 900;
        }
	}
}
