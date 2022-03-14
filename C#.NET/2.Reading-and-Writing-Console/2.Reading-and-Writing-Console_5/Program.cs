using System;

namespace _2.Reading_and_Writing_Console_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program by taking two integer values and return the value by adding in the
            int firstnum;
            int secondnum;

            Console.Write("Enter first number: ");
            firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondnum = Convert.ToInt32(Console.ReadLine());

            int sum = firstnum + secondnum;
            Console.WriteLine("Sum: " + sum);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
