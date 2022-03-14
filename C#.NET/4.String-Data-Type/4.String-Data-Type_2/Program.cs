using System;

namespace _4.String_Data_Type_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program in C# Sharp to find the length of a string without using library function.
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            int length = 0;

            foreach (char c in input)
            {
                length++;
            }

            Console.WriteLine(length);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
