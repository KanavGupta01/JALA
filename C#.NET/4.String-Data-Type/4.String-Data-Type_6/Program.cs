using System;

namespace _4.String_Data_Type_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to find maximum occurring character in a string
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            int[] occurence = new int[256];

            int maxOccurence = 0;

            int maxChar = 0;

            foreach (char c in input)
            {
                occurence[c]++;
            }

            for (int i = 0; i < occurence.Length; i++)
            {
                if (occurence[i] > maxOccurence)
                {
                    maxOccurence = occurence[i];
                    maxChar = i;
                }
            }

            Console.WriteLine("Most frequent character is " + (char)maxChar + " occuring " + maxOccurence + " times.");

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
