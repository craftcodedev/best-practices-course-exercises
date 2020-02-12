using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Infrastructure.Service.Hashing
{
    public interface IHashing
    {
        string Hash(string password);
    }
}
