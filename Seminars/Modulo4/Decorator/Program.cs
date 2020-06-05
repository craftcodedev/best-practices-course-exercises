using System;
using Directos.Module4.Decorator.Solution;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Contract contract = new Developer(15);
            Console.WriteLine(contract.CalculateSalary());
            contract = new Commision(contract, 10, 20);
            Console.WriteLine(contract.CalculateSalary());
            contract = new Plus(contract, 30);
            Console.WriteLine(contract.CalculateSalary());
        }
    }
}
