using AppCraftCode.src.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Domain.UserAggregate
{
    public class UserId : UUID
    {
        public UserId(string value) : base(value) { }
    }
}
