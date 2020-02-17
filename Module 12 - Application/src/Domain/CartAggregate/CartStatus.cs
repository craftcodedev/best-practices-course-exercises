using App.Shared.Domain;
using App.Domain.CartAggregate.Exception;
using System;

namespace App.Domain.CartAggregate
{
    public class CartStatus : StringValueObject
    {
        public const string OPEN_STATUS = "open";
        public const string CLOSED_STATUS = "closed";
        private string value;

        public CartStatus(string value) : base(value)
        {
            if (value != CartStatus.OPEN_STATUS && value != CartStatus.CLOSED_STATUS) {
                throw InvalidCartAttributeException.FromValue("status", value);
            }
        }

        public bool isClosed()
        {
            if (this.value == CartStatus.CLOSED_STATUS) {
                return true;
            }

            return false;
        }
    }
}
