using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");

            string temp = Console.ReadLine();

            double inputTemp = double.Parse(temp);

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");

            string input = Console.ReadLine();

           if (input == "F")
            {
                double Tc = (inputTemp - 32) / 1.8;
                Console.Write(inputTemp + "F is " + Tc + "C");
            }
           else if (input == "C")
            { 
                double Tf = (inputTemp * 1.8) + 32;
                Console.Write(inputTemp + "C is " + Tf + "F");
            }
           

            Console.ReadLine();

        }
    }
}
