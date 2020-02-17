using App.Shared.Domain;
using App.Domain.OrderAggregate.Exception;

namespace App.Domain.OrderAggregate
{
    public class OrderStatus : StringValueObject
    {
        public const string INPROGRESS_STATUS = "InProcess";
        public const string FINISHED_STATUS = "Finished";
        public const string CANCELED_STATUS = "Canceled";
        private string value;

        public OrderStatus(string value) : base(value)
        {

            if (value != OrderStatus.INPROGRESS_STATUS && value != OrderStatus.FINISHED_STATUS && value != OrderStatus.CANCELED_STATUS) {
                throw InvalidOrderAttributeException.FromValue("status", value);
            }
        }
    }
}