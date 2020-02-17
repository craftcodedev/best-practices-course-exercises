using App.Shared.Domain;

namespace App.Domain.CartAggregate
{
    public class Item
    {
        /**private ItemId id;
        private ItemName name;
        private ItemPrice price;
        private ItemCartId cartId;

        private Item(
            ItemId id,
            ItemName name,
            ItemPrice price,
            ItemCartId cartId
        ) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.cartId = cartId;
        }

        public static Item Create(
            ItemId id,
            ItemName name,
            ItemPrice price,
            ItemCartId cartId)
        {
            Item item = new Item(id, name, price, cartId);

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
        
        public ItemCartId cartId()
        {
            return this.cartId;
        }**/
    }
}