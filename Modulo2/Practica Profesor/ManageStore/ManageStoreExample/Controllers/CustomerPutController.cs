using ManageStore.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Controllers
{
    public class CustomerPutController
    {
        private CreateCustomerUseCase createCustomerUse;

        public CustomerPutController(CreateCustomerUseCase createCustomerUse)
        {
            this.createCustomerUse = createCustomerUse;
        }

        public void CreateCustomerAction(Request request)
        {
            CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest(
                Int16.Parse(request.Get("id")),
                request.Get("name")
            );

            this.createCustomerUse.Execute(createCustomerRequest);
        }
    }
}
