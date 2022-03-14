using System;

namespace _1.Basics_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program to swap 2 numbers
            Console.Write("Enter first number: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");

            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a + "," + b);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
