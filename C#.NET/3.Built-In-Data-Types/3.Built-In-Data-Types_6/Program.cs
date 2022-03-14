using System;
using System.Linq;

namespace _3.Built_In_Data_Types_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program that takes three letters as input and display them in Reverse Order
            Console.Write("Enter a letter: ");

            char input = Console.ReadKey().KeyChar;

            Console.WriteLine();

            input = Char.ToLower(input);

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(input))
            {
                Console.WriteLine("It is a lowercase vowel");
            }
            else if (Char.IsDigit(input))
            {
                Console.WriteLine("It is a digit");
            }
            else
            {
                Console.WriteLine("It is some other symbol");
            }

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
