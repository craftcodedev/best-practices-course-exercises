using AppCraftCode.src.Application.UseCase.User;
using AppCraftCode.src.Shared.Domain.Bus.UseCase;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.UI.Rest.Controller
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUseCaseBus useCaseBus;

        public UserController(IUseCaseBus useCaseBus)
        {
            this.useCaseBus = useCaseBus;
        }
               
        [HttpPost(Name = nameof(SignUp))]
        public IActionResult SignUp([FromBody] SignUpUserRequest request)
        {
            IResponse response = this.useCaseBus.Dispatch(request);
            return Ok(response);
        }
    }
}
