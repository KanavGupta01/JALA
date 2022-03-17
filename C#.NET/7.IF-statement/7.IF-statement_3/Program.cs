using System;
using System.Linq;

namespace _7.IF_statement_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
            char input;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Enter a letter: ");
            input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (vowels.Contains(input))
            {
                Console.WriteLine(input + " is a vowel");
            }
            else
            {
                Console.WriteLine(input + " is a consonant");
            }

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
