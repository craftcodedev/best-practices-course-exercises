using Refactoring.Code_Smells;
using System;
using System.Globalization;

namespace TecnicasRefactoring.Code_Smells.WithCodeSmells
{
    public class WithCodeSmells
    {
        private void CheckCustomerAndProductNotEmptyIsValid(CustomerRequest request)
        {
            if(!string.IsNullOrEmpty(request.CustomerProduct.ProductNumber) &&
                !string.IsNullOrEmpty(request.Customer.CustomerID))
            {
                throw new Exception(HandledErrors.InvalidBothParameterMessage);
            }
        }

        private void CheckCustomerNotEmptyIsValid(CustomerRequest request)
        {
            if (string.IsNullOrEmpty(request.CustomerProduct.ProductNumber) &&
                string.IsNullOrEmpty(request.Customer.CustomerID))
            {
                throw new Exception(HandledErrors.CustomerEmptyMessage);
            }
        }

        private void CheckCustomerLengthIsValid(CustomerRequest request)
        {
            if (request.Customer.CustomerID.Length > request.customerIDFieldLength)
            {
                throw new Exception(HandledErrors.CustomerInvalidLengthMessage);
            }

            request.Customer.CustomerID = request.Customer.CustomerID.PadLeft(
                                            request.customerIDFieldLength, Convert.ToChar("0", CultureInfo.CurrentCulture));
        }

        private void CheckProductLengthIsValid(CustomerRequest request)
        {
            if (request.CustomerProduct.ProductNumber.Length > request.productFieldLength)
            {
                throw new Exception(HandledErrors.ProductInvalidLengthMessage);
            }

            request.CustomerProduct.ProductNumber = request.CustomerProduct.ProductNumber.PadLeft(
                                                    request.productFieldLength,
                                                    Convert.ToChar("0", CultureInfo.CurrentCulture));
        }

        public void ValidateRequest(CustomerRequest request)
        {
            CheckCustomerAndProductNotEmptyIsValid(request);
            CheckCustomerNotEmptyIsValid(request);
            CheckCustomerLengthIsValid(request);
            CheckProductLengthIsValid(request);
        }        
    }
}
