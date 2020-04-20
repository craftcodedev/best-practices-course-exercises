using System;
using RefactorController.src.Model;
using RefactorController.src.Repository;
using RefactorController.src.UseCase;

namespace RefactorController.src.Controller
{
    public class CustomerController
    {
        private CreateCustomerUseCase _customerUseCase;

        public CustomerController(CreateCustomerUseCase customerUseCase)
        {
            _customerUseCase = customerUseCase;
        }

        public CustomerDTO CustomerAction(Request request)
        {
            CreateCustomerRequest requestCustomer = new CreateCustomerRequest(request.Get("id"), request.Get("name"));
            return _customerUseCase.Execute(requestCustomer);
        }
    }
}