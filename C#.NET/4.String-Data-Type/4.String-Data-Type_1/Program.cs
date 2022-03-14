using System;

namespace _4.String_Data_Type_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a Program to Reverse a String without using Reverse function
            Console.Write("Enter a string: ");

            char[] input = Console.ReadLine().ToCharArray();

            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            Console.Write("Reverse String is: " + reverse);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
