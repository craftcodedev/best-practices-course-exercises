using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.GuardClause
{
    public static class GuardChecking
    {
        public static void AgainstNull(object argument, string argumentName)
        {
            if(argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static void AgainstInvalidTerm(TermEnum term, string argumentName)
        {
            if(term != TermEnum.Annually && term != TermEnum.Monthly)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}
