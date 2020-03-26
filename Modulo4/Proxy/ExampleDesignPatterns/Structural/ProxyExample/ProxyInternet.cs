using Proxy.Impl;
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyInternet : IInternet
    {
        private RealInternet _realInternet;

        public ProxyInternet(RealInternet realInternet)
        {
            _realInternet = realInternet;
        }

        public void ConnectTo(string serverHost)
        {
            List<string> webs = new List<string>
            {
                "abc.com",
                "dfr.com",
                "ert.com"
            };

            if(webs.Contains(serverHost))
            {
                throw new Exception("Access denied to: " + serverHost);
            }

            _realInternet.ConnectTo(serverHost);
        }
    }
}
