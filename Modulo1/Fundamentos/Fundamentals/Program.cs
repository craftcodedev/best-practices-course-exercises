using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var lista1 = CreateListGen(1, 2, 3);
            var lista2 = CreateListGen("1", "2", "3");
        }

        private static List<T> CreateListGen<T>(params T[] list)
        {
            List<T> listaGen = new List<T>();

            foreach (var ls in listaGen)
            {
                listaGen.Add(ls);
            }

            return listaGen;
        }
    }
}
