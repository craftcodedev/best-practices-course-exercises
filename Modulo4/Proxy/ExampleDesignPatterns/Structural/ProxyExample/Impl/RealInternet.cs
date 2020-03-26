using System;
using Proxy.Interfaces;

namespace Proxy.Impl
{
    public class RealInternet : IInternet
    {
        public void ConnectTo(string serverHost)
        {
            Console.WriteLine("Connecting to " + serverHost);
        }
    }
}
