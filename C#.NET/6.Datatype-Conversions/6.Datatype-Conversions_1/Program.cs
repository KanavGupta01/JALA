using System;

namespace _6.Datatype_Conversions_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to Implicit Type Conversion
            int firstnum;
            long secondnum;

            Console.Write("Enter first number(int): ");
            firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number(long): ");
            secondnum = Convert.ToInt64(Console.ReadLine());

            long firstconverted = firstnum;

            Console.WriteLine("int: " + firstconverted);
            Console.WriteLine("long: " + secondnum);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
