using App.Application.UseCase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Shared.Domain.Bus.UseCase;

namespace App.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IUseCaseBus useCaseBus;
        public CustomerController(IUseCaseBus useCaseBus)
        {
            this.useCaseBus = useCaseBus;
        }
        
        [HttpGet(Name = nameof(GetAll))]
        public IActionResult GetAll()
        {
            System.Console.Write(this.useCaseBus.ToString());
            return Ok("ss");
        }

        [HttpPost(Name = nameof(SignUp))]
        public IActionResult SignUp([FromBody] SignUpCustomerRequest request)
        {
            IResponse response = this.useCaseBus.Dispatch(request);

            return Ok(response);
        }
    }
}
