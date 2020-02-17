using App.Shared.Domain;

namespace App.Domain.OrderAggregate
{
    public class Item
    {
        /**private ItemId id;
        private ItemName name;
        private ItemPrice price;
        private ItemOrderId orderId;

        private Item(
            ItemId id,
            ItemName name,
            ItemPrice price,
            ItemOrderId orderId
        ) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.orderId = orderId;
        }

        public static Item Create(
            ItemId id,
            ItemName name,
            ItemPrice price,
            ItemOrderId orderId)
        {
            Item item = new Item(id, name, price, orderId);

            return item;
        }
        
        public ItemId Id()
        {
            return this.id;
        }
        
        public ItemName name()
        {
            return this.name;
        }
        
        public ItemPrice price()
        {
            return this.price;
        }
        
        public ItemOrderId orderId()
        {
            return this.orderId;
        }**/
    }
}