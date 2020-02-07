using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PremiumMemberShip : MemberShip
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price * (1 - 0.1M);
        }
    }
}
