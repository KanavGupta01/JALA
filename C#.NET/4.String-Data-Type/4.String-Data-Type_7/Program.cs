using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.String_Data_Type_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to sort a string array in ascending order
            Console.Write("Enter a string: ");

            string input = Console.ReadLine();

            char[] sorted = input.ToLower().ToCharArray();

            char temp;

            int counter = 0;

            do
            {
                counter = 0;

                for (int i = 0; i < sorted.Length - 1; i++)
                {
                    if (sorted[i] > sorted[i + 1])
                    {
                        temp = sorted[i];
                        sorted[i] = sorted[i + 1];
                        sorted[i + 1] = temp;
                        counter++;
                    }
                }
            }
            while (counter > 0);

            Console.WriteLine(String.Join("", sorted));

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
