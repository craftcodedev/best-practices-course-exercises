using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Calculator
    {
        public double Calculate(List<double> values, IAverageMethod method)
        {
            return method.Calculate(values);
        }
    }
}
