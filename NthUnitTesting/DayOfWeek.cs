using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class DayOfWeek
    {
        public static void ReadInput()
        {
            int date, month, year;

            //Getting date from 1-30
            Console.WriteLine("Enter the date");
            date = Convert.ToInt32(Console.ReadLine());
            //Getting date from 1-12
            Console.WriteLine("Enter the Month");
            month = Convert.ToInt32(Console.ReadLine());
            //Getting date from YYYY format
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());


            GetDayOfWeek(date, month, year);


        }
        //method for getting date
        private static void GetDayOfWeek(int d,int m,int y)
        {
            //array for days of week
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //calculating day of week by given georgian formula
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            //printing output
            Console.WriteLine($"The day on this {d}-{m}-{y} date is {daysOfWeek[d0]} ");
        }
    }
}
