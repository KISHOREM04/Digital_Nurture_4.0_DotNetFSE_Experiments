using System;

class Program
{
    static double PredictFutureValue(double presentValue, double rate, int years)
    {
        if (years == 0)
            return presentValue;

        return (1 + rate) * PredictFutureValue(presentValue, rate, years - 1);
    }

    static void Main()
    {
        double presentValue = 10000;
        double annualGrowthRate = 0.08;
        int years = 5;

        Console.WriteLine("Financial Forecast Inputs:");
        Console.WriteLine($"Present Value      : ₹{presentValue:F2}");
        Console.WriteLine($"Annual Growth Rate : {annualGrowthRate * 100}%");
        Console.WriteLine($"Years              : {years}");

        double futureValue = PredictFutureValue(presentValue, annualGrowthRate, years);

        Console.WriteLine($"\nPredicted Future Value after {years} years: ₹{futureValue:F2}");
    }
}