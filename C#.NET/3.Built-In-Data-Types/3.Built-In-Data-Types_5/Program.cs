using System;
using System.Linq;

namespace _3.Built_In_Data_Types_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program that takes three letters as input and display them in Reverse Order
            char[] chars = new char[3];

            Console.Write("Enter first letter: ");

            chars[0] = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second letter: ");

            chars[1] = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter third letter: ");

            chars[2] = Console.ReadKey().KeyChar;
            Console.WriteLine();


            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i]);
            }

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
