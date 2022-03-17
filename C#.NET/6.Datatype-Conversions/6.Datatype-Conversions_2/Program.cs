using System;

namespace _6.Datatype_Conversions_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write an example of explicit type conversion
            double x;

            Console.Write("Enter value of X: ");
            x = Convert.ToDouble(Console.ReadLine());

            int output = (int) x;

            Console.WriteLine("Value of X is " + output);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
