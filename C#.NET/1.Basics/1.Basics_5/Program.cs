using System;

namespace _1.Basics_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to check whether it is odd or even
            Console.Write("Enter a number: ");

            int input = Convert.ToInt32(Console.ReadLine());

            string output = input % 2 == 0 ? "even" : "odd";

            Console.WriteLine(output);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
