
using elearning.Shared.Domain.Bus.Query;

namespace elearning.Shared.Infrastructure.Service.JSONApi
{
    public interface IJsonApiEncoder
    {
        object EncodeData(IResponse response);
        object EncodeError(IResponse response);
    }
}