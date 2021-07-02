using System;

namespace NthUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nth Unit testing problems");

            Console.WriteLine( "Menu\n1.Vending Machine\n2.Day of week\n3.Temperature Conversion\n4.Monthly Payment\n5.Newton Square Root\n6.Exit");

            Console.WriteLine("Enter The option");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    VendingMachine.ReadInput();
                    break;
                case 2:
                    DayOfWeek.ReadInput();
                    break;
                case 3:
                    TemperatureConversion.ReadInput();
                    break;
                case 4:
                    MonthlyPayment.ReadInput();
                    break;
                case 5:
                    NewtonSquareRoot.ReadInput();
                    break;
                case 6:
                    Console.WriteLine("Exited");
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
        }
    }
}
