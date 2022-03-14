using System;

namespace _4.String_Data_Type_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a Program to Convert Upper case to Lower Case using LowerCase method  
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            Console.WriteLine(input.ToLower());

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
