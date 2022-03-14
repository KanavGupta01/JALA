using System;

namespace _4.String_Data_Type_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a Program to Replace String in String using Replace function
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            string output = input.Replace("no", "yes");

            Console.Write(output);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
