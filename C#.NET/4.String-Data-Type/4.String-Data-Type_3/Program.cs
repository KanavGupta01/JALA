using System;
using System.Linq;

namespace _4.String_Data_Type_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a Program to calculate the length of the string using count function
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            int length = input.Count();

            Console.WriteLine(length);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
