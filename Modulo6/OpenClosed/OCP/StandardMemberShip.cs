using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class StandardMemberShip : MemberShip
    {
        public override decimal CalculatePrice(decimal price)
        {
            return price;
        }
    }
}
