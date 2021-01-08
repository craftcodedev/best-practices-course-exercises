using elearning.Shared.Domain.Bus.Query;
using elearning.Shared.Infrastructure.Service.JSONApi;
using elearning.Shared.UI.Rest.Controller.Response;
using Microsoft.AspNetCore.Mvc;

namespace elearning.Shared.UI.Rest.Controller
{
    public class QueryControllerBase : ControllerBase
    {
        private IQueryBus queryBus;
        private IJsonApiEncoder jsonApiEncoder;

        public QueryControllerBase(IQueryBus queryBus, IJsonApiEncoder jsonApiEncoder)
        {
            this.queryBus = queryBus;
            this.jsonApiEncoder = jsonApiEncoder;
        }

        protected IActionResult Ask(IQuery query)
        {
            try {
                IResponse response = queryBus.Ask(query);
                object data = jsonApiEncoder.EncodeData(response);
                return StatusCode(200, data);
            } catch (System.Exception Exception) {
                HttpResponse response = (new FailureResponseCreator(Exception)).Create();
                object ErrorData = jsonApiEncoder.EncodeError(response);
                return StatusCode(response.Code, ErrorData);
            }
        }
    }
}
