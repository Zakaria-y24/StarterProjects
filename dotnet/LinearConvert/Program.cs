using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");

            string length = Console.ReadLine();

            double lengthInput = double.Parse(length);

            Console.Write("Is the measurement in (m)eter, or (f)eet? ");

            string measurementInput = Console.ReadLine();

            if (measurementInput == "m")
            {
                double m = lengthInput * 3.2808399;
                Console.WriteLine(lengthInput + "m is " + m + "f");
            }
            if (measurementInput == "f"){
                double f = lengthInput * 0.3084;
                Console.WriteLine(lengthInput + "f is " + f + "m");
            }
            Console.ReadLine();


        }
    }
}
