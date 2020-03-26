using ManageStore.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Controller
{
    public class CustomerPutController
    {
        private CreateCustomerUseCase customerUseCase;

        public CustomerPutController(CreateCustomerUseCase customerUseCase)
        {
            this.customerUseCase = customerUseCase;
        }

        public void CreateCustomerAction(Request request)
        {
            CreateCustomerRequest createRequest = new CreateCustomerRequest(
                request.Get("id"),
                request.Get("name")
                );

            customerUseCase.Execute(createRequest);
        }

    }
}
