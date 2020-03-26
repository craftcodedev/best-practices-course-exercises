using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.GuardClause
{
    public class SubscriptionParams
    {
        public string User { get; set; }
        public string Subscription { get; set; }
        public TermEnum Term { get; set; }
    }
}
