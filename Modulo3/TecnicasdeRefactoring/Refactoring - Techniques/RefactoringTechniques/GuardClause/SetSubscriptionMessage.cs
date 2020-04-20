using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.GuardClause
{
    public class SetSubscriptionMessage
    {
        public static bool SetMessage(TermEnum term)
        {
            Console.WriteLine(term.ToString() + " subscription was a success");
            return true;
        }
    }
}
