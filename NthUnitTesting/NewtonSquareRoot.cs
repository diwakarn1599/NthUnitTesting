using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class NewtonSquareRoot
    {
        public static void ReadInput()
        {
            double c;
            //geting input from user
            Console.WriteLine("Enter the value of c");
            c = Convert.ToDouble(Console.ReadLine());
            FindSquareRoot(c);

        }
        
        private static void FindSquareRoot(double c)
        {
            double t = c;
            double root;
            //l value
            double l = 0.00001;
            while (true)
            {
                //average of c/t and t
                root = 0.5 * (t + (c / t));
                if (Math.Abs(root - t) < l)
                {
                    break;
                }
                t = root;
            }

            //printing output
            Console.WriteLine($"The Root is = {root}");
        }
    }
}
