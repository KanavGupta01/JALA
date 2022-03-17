using System;

namespace _6.Datatype_Conversions_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program of built in type conversion methods
            float firstnum;
            double secondnum;

            Console.Write("Enter string: ");
            firstnum = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter int: ");
            secondnum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("string to float: " + firstnum);
            Console.WriteLine("int to double: " + secondnum);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
