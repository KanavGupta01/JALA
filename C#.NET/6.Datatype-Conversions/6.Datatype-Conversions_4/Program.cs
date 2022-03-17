using System;

namespace _6.Datatype_Conversions_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that converts various value types to string type

            float firstnum;
            double secondnum;

            Console.Write("Enter integer: ");
            firstnum = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter float: ");
            secondnum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("int.toString() : " + firstnum.ToString());
            Console.WriteLine("float.toString() : " + secondnum.ToString());

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
