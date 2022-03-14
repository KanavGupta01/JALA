using System;

namespace _5.Operators_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write the program to demonstrate the working of Unary Arithmetic Operators ?
            int firstnum;

            Console.Write("Enter first number: ");
            firstnum = Convert.ToInt32(Console.ReadLine());
            int input = firstnum;

            firstnum++;
            Console.WriteLine(firstnum + "++" + " = " + (firstnum));
            firstnum = input;

            firstnum--;
            Console.WriteLine(firstnum + "--" + " = " + (firstnum));
            firstnum = input;

            ++firstnum;
            Console.WriteLine("++" + firstnum + " = " + (firstnum));
            firstnum = input;

            --firstnum;
            Console.WriteLine("--" + firstnum + " = " + (firstnum));
            firstnum = input;

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
