using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class MonthlyPayment
    {
        public static void ReadInput()
        {
            double principle, rateOfInterest, years;

            //Getting principle amount
            Console.WriteLine("Enter the Principle amount");
            principle = Convert.ToDouble(Console.ReadLine());

            //Getting number of years
            Console.WriteLine("Enter the number of years");
            years = Convert.ToDouble(Console.ReadLine());

            //Getting rate of interest
            Console.WriteLine("Enter the rate of interest");
            rateOfInterest = Convert.ToDouble(Console.ReadLine());


            GetMonthlyPayment(principle, years, rateOfInterest);


        }

        private static void GetMonthlyPayment(double principle, double years, double rateOfInterest)
        {
            //By Given formula
            double n = 12 * years;//to convert years into months
            double r = rateOfInterest / (12 * 100);
            double x = Math.Pow(1 + r, n);// (1+r)^n

            //Formula for calculating payment
            double payment = (principle*r*x)/(x-1);

            //printing output
            Console.WriteLine($"Monthly Payment is = {Math.Round(payment)}");



        }
    }
}
