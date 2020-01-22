using System;

namespace ManageStore.Repository.Exception
{
    public class CustomerFoundException : System.Exception
    {
        public CustomerFoundException(string message): base(message){}

        public static void FromId(int id)
        {
            throw new CustomerFoundException(string.Format("Customer found with id: {0}", id));
        }
    }
}