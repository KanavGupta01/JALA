using System;

namespace _7.IF_statement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to find whether a given year is a leap year or not.
            int input = 0;

            Console.Write("Enter a year: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input % 4.0 == 0)
            {
                Console.WriteLine(input + " is a leap year");
            }
            else
            {
                Console.WriteLine(input + " is not a leap year");
            }

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}