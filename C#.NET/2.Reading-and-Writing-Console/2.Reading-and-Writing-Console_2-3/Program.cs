using System;

namespace _2.Reading_and_Writing_Console_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Declare a variable name of any datatype and read the name in the output
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            // 3.Enter your name and from WriteLine function and print the output
            Console.WriteLine(name);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}