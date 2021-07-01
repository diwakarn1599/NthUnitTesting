using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class TemperatureConversion
    {
        public static void ReadInput()
        {
            
            Console.WriteLine("1.Celsius to Fahrenheit\n2.Fahrenheit to Celsius");
            Console.WriteLine("Choose option");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter degree in celsius ");
                    double deg = Convert.ToDouble(Console.ReadLine());
                    ToFahrenheit(deg);
                    break;
                case 2:
                    Console.WriteLine("Enter degree in Fahrenheit ");
                    double degree = Convert.ToDouble(Console.ReadLine());
                    ToCelsius(degree);
                    break;
            }
            
            


        }

        private static void ToFahrenheit(double deg)
        {
            double f = deg * 9 / 5 + 32;
            Console.WriteLine($"{deg}C = {f}F");
        }
        private static void ToCelsius(double degree)
        {
            double c = (degree - 32) * 5 / 9;
            Console.WriteLine($"{degree}F = {c}C");
        }
    }
}
