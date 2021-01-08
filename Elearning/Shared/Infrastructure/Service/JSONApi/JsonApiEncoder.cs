using elearning.Shared.Application.Bus.Query.Response;
using elearning.Shared.Domain.Bus.Query;
using JsonApiSerializer;
using Newtonsoft.Json;

namespace elearning.Shared.Infrastructure.Service.JSONApi
{
    public class JsonApiEncoder : IJsonApiEncoder
    {
        public object EncodeData(IResponse response)
        {
            if (response is CollectionResponse<IResponse>)
            {
                CollectionResponse<IResponse> collectionResponse = (CollectionResponse<IResponse>)response;
                var items = collectionResponse.Items();
                string collectionResponseJson = JsonConvert.SerializeObject(items, new JsonApiSerializerSettings());
                return JsonConvert.DeserializeObject<dynamic[]>(collectionResponseJson, new JsonApiSerializerSettings());
            }

            string responseJson = JsonConvert.SerializeObject(response, new JsonApiSerializerSettings());
            return JsonConvert.DeserializeObject(responseJson, new JsonApiSerializerSettings());
        }

        public object EncodeError(IResponse response)
        {
            string json = JsonConvert.SerializeObject(response, new JsonApiSerializerSettings());
            return JsonConvert.DeserializeObject(json, new JsonApiSerializerSettings());
        }
    }
}