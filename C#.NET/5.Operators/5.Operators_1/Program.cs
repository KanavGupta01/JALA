using System;

namespace _5.Operators_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write the program to demonstrate the working of Binary Arithmetic Operators ?
            int firstnum;
            int secondnum;

            Console.Write("Enter first number: ");
            firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstnum + "+" + secondnum + " = " + (firstnum + secondnum));
            Console.WriteLine(firstnum + "-" + secondnum + " = " + (firstnum - secondnum));
            Console.WriteLine(firstnum + "*" + secondnum + " = " + (firstnum * secondnum));
            Console.WriteLine(firstnum + "/" + secondnum + " = " + (firstnum / (double)secondnum));

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}