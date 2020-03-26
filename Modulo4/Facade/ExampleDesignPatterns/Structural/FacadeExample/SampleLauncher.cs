using Facade.Interfaces;
using Facade.Inventory;
using System;

namespace Facade
{
	public class SampleLauncher
	{
		static void Main(string[] args)
		{
            IInventory inventory = new InventoryManager();
            IOrderVerify orderVerify = new OrderVerificationManager();
            ICosting costManger = new CostManager();
            IPaymentGateway paymentGateWay = new PaymentGatewayManager();
            ILogistics logistics = new LogisticsManager();


            // Creating the Order/Product details
            OrderDetails orderDetails = new OrderDetails("C# Design Pattern Book",
                                                         "Simplified book on design patterns in C#",
                                                          500,
                                                          10,
                                                          "Street No 1",
                                                          "Educational Area",
                                                          1212,
                                                          "4156213754"
                                                         );

            // Client Code without Facade.

            // Updating the inventory.

            inventory.Update(orderDetails.ProductNo);

            // Verfying various details for the order such as the shipping address.

            orderVerify.VerifyShippingAddress(orderDetails.PinCode);



            // Calculating the final cost after applying various discounts.

            orderDetails.Price = costManger.ApplyDiscounts(orderDetails.Price,
                                                         orderDetails.DiscountPercent
                                                        );

            // Going through various steps if payment gateway like card verification, charging from the card.

            paymentGateWay.VerifyCardDetails(orderDetails.CardNo);
            paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);

            // Completing the order by providing Logistics.

            logistics.ShipProduct(orderDetails.ProductName, string.Format("{0}, {1} - {2}.",
                                  orderDetails.AddressLine1, orderDetails.AddressLine2,
                                  orderDetails.PinCode));

            //Facade

            OrderOnlineFacade facade = new OrderOnlineFacade(inventory, costManger,
                logistics, orderVerify, paymentGateWay);

            facade.FinalizeOrder(orderDetails);




		    Console.ReadLine();
        }
    }
}
