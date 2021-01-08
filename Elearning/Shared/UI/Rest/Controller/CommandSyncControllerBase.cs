using elearning.Shared.Domain.Bus.Command;
using elearning.Shared.Infrastructure.Bus.Command;
using elearning.Shared.Infrastructure.Service.JSONApi;
using elearning.Shared.UI.Rest.Controller.Response;
using Microsoft.AspNetCore.Mvc;

namespace elearning.Shared.UI.Rest.Controller
{
    public class CommandSyncControllerBase : ControllerBase
    {
        private ICommandBus commandBus;
        private IJsonApiEncoder jsonApiEncoder;

        public CommandSyncControllerBase(ICommandBus commandBus, IJsonApiEncoder jsonApiEncoder)
        {
            this.commandBus = commandBus;
            this.jsonApiEncoder = jsonApiEncoder;
        }

        protected IActionResult Dispatch(ICommand command)
        {
            try
            {
                commandBus.Dispatch(command);
                return StatusCode(200);
            }
            catch (System.Exception Exception)
            {
                HttpResponse response = (new FailureResponseCreator(Exception)).Create();
                object ErrorData = jsonApiEncoder.EncodeError(response);
                return StatusCode(response.Code, ErrorData);
            }
        }
    }
}