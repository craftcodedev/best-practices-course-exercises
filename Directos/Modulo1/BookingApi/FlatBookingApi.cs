using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Directos.Modulo1.BookingApi
{
    public class FlatBookingApi : BookingApi
    {
        public FlatBookingApi()
        {
        }

        public object FindFlats()
        {
            return this.client.Request("flats");
        }
    }
}
