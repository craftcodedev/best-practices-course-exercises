using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Code_Smells
{
    public static class HandledErrors
    {
        public static string CustomerInvalidLengthMessage { get { return "Invalid customer length"; } }
        public static string ProductInvalidLengthMessage { get { return "Invalid product length"; }  }
        public static string CustomerEmptyMessage { get { return "Customer is empty"; }  }
        public static string InvalidBothParameterMessage { get { return "Invalid both params"; }  }
    }
}
