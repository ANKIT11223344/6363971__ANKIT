using System;
using System.Collections.Generic;

class FinancialForecast
{
    static void Main()
    {
        
        Console.Write("Enter initial investment amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        List<double> yearlyBalances = new List<double>();

        for (int year = 1; year <= years; year++)
        {
            principal = principal * (1 + annualRate);  
            yearlyBalances.Add(principal);
        }

        Console.WriteLine("\nYearly Forecast:");
        for (int i = 0; i < yearlyBalances.Count; i++)
        {
            Console.WriteLine($"Year {i + 1}: {yearlyBalances[i]:C2}");
        }
    }
}