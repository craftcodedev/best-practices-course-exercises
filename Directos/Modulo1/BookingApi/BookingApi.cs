using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Directos.Modulo1.BookingApi
{
    public class BookingApi
    {
        public HttpClient client;

        public BookingApi()
        {
            this.client = new HttpClient();
        }

        public object Request(string resource)
        {
            try
            {
                string endpoint = "http://booking/" + resource;
                var task = Task.Run(() => this.client.GetStringAsync(endpoint));
                task.Wait();
                string results = task.Result;

                return JsonConvert.DeserializeObject(results);

            }
            catch (HttpRequestException e)
            {
                throw e;
            }
        }
    }
}
