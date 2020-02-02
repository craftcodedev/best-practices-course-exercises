using System;
using System.Collections.Generic;

namespace Strategy
{
    public class SampleLauncher
	{
	    static void Main(string[] args)
	    {
	        List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

            //OLD
	        Calculator calculator = new Calculator();
            //calculatorOld.CalculateAverage(_values, Calculator.AveragingMethod.Mean);
            //calculatorOld.CalculateAverage(_values, Calculator.AveragingMethod.Median);

            calculator.Calculate(values, new CalculateMeanStrategy());
            calculator.Calculate(values, new CalculateMedianStrategy());



            Console.ReadLine();
	    }
	}
}