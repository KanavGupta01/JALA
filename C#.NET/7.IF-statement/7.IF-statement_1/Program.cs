using System;

namespace _7.IF_statement_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to check whether a given number is positive or negative
            int input = 0;

            Console.Write("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine(input + " is a negative number");
            }
            else 
            {
                Console.WriteLine(input + " is a positive number");
            }

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
