using System;

namespace ManageStore.Repository.Exception
{
    public class CustomerNotFoundException : System.Exception
    {
        public CustomerNotFoundException(string message): base(message){}

        public static void FromId(int id)
        {
            throw new CustomerNotFoundException(string.Format("Customer not found with id: {0}", id));
        }
    }
}