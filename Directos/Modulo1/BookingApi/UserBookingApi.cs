using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Directos.Modulo1.BookingApi
{
    public class UserBookingApi : BookingApi
    {
        public UserBookingApi()
        {
        }

        public object FindUsers()
        {
            return this.client.Request("users");
        }
    }
}
