using ManageStore.Model.Customer;
using ManageStore.Service.Convert;
using ManageStore.UseCase;
using System;

namespace ManageStore.Controllers
{
    public class CustomerGetController
    {
        private FindCustomerByIdUseCase findCustomerByIdUseCase;
        private CustomerConverter CustomerConverter;

        public CustomerGetController(FindCustomerByIdUseCase findCustomerByIdUseCase, CustomerConverter CustomerConverter)
        {
            this.findCustomerByIdUseCase = findCustomerByIdUseCase;
            this.CustomerConverter = CustomerConverter;
        }

        public CustomerDTO GetCustomerAction(Request request)
        {
            FindCustomerByIdRequest findCustomerByIdRequest = new FindCustomerByIdRequest(Int16.Parse(request.Get("id")));

            Customer Customer = this.findCustomerByIdUseCase.Execute(findCustomerByIdRequest);

            return this.CustomerConverter.Convert(Customer);
        }
    }
}
