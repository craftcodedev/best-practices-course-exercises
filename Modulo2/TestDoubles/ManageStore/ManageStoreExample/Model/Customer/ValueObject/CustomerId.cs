using Model;
using System;

namespace ManageStore.Model.Customer.ValueObject
{
    public class CustomerId : ValueObject<CustomerId>
    {
        public int CustomerID { get; }

        public CustomerId(int customerId)
        {
            CustomerID = customerId;

            if (IsNotValid(customerId))
            {
                throw new System.Exception("Invalid customer");
            }

            value = Convert.ToString(customerId);
        }

        private bool IsNotValid(int customerId)
        {
            try
            {
                return customerId.Equals(0);
            }
            catch
            {
                return true;
            }
        }

        protected override bool EqualsCore(CustomerId customerId)
        {
            return CustomerID == customerId.CustomerID;
        }
    }
}
