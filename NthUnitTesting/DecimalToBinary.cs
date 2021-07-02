using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class DecimalToBinary
    {
        public static void ReadInput()
        {
            int number;
            //geting input from user
            Console.WriteLine("Enter the value of Decimal number");
            number = Convert.ToInt32(Console.ReadLine());

            GetBinaryNumber(number);

        }

        private static void GetBinaryNumber(int number)
        {
            int originalNumber = number;

            //list used to store binary numbers
            List<int> binary = new List<int>();

            //decimal to binary conversion
            while (number > 0)
            {
                int x = number % 2;
                binary.Add(x);
                number /= 2;
            }

            //printing output
            Console.WriteLine($"The Binary Representation of {originalNumber} is");
            for(int i = binary.Count-1; i >= 0; i--)
            {
                //printing in reverse order
                Console.Write(binary[i]);
            }
        }
    }
}
