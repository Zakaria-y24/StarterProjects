using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");

            string decimalValues = Console.ReadLine();

            string[] individualDecimalValues = decimalValues.Split(" ");

            for (int i = 0; i < individualDecimalValues.Length; i++)
            {

                int value = int.Parse(individualDecimalValues[i]);

                string binary = Convert.ToString(value, 2);

                Console.WriteLine(decimalValues + " in a binary is " + binary);

            }
        }
    }
}
