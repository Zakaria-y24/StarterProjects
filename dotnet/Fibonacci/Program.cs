using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int a = 0;
            int b = 1;
            string startingNumbers = "0, 1";
            
            Console.Write("Please enter a number: ");
     
            int numberEntered = int.Parse(Console.ReadLine()); 

            c = a + b;

            bool keepCounting = true;

            Console.Write(startingNumbers);

            while (keepCounting)
            {
                if (numberEntered == 0)
                {
                    break;
                }

                Console.Write(", " + c);
                a = b;
                b = c;
                c = a + b;
 
               if (c > numberEntered)
                {
                    keepCounting = false;

                }
            }

            
        }
    }
}
