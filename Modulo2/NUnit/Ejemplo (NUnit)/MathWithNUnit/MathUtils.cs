using System;
using System.Collections.Generic;

namespace MathWithNUnit
{
    public static class MathUtils
    {
        public static int CalculateFibonacciNumber(int numberIndex)
        {
            if(numberIndex < 0)
            {
                throw new ArgumentException("El índice no puede ser negativo");
            }

            if (numberIndex == 0 || numberIndex == 1)
            {
                return numberIndex;
            }

            return CalculateFibonacciNumber(numberIndex - 1) + CalculateFibonacciNumber(numberIndex - 2);
        }

        public static List<int> GetFibonacciSequence(int maxNumberIndexInclusive)
        {
            List<int> result = new List<int>();

            for(int i = 0; i <= maxNumberIndexInclusive; ++i)
            {
                result.Add(CalculateFibonacciNumber(i));
            }

            return result;
        }
    }
}
