namespace Observer
{
    public interface IProduct
    {
        void Subscribe(Customer customer);
        void Unsubscribe(Customer customer);
        void Notify();

    }
}