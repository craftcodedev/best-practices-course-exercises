using System;
using System.Collections.Generic;

namespace Directos.Module4.Proxy
{
    public interface ICache
    {
        void Set(string key, string value);
 
        string Get(string key);
    }
}