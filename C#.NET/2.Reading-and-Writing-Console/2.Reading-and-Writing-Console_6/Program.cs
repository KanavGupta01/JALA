using System;

namespace _2.Reading_and_Writing_Console_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to enter password by converting it to char array into string print the
            Console.Write("Enter Password: ");

            char[] input = Console.ReadLine().ToCharArray();

            string output = String.Join("", input);
            Console.WriteLine("Password: " + output);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
