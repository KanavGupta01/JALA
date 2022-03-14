using System;

namespace _3.Built_In_Data_Types_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Write a C# Sharp program that takes two numbers as input and perform an operation(+, -, *, x,/) on them and displays the result of that operation
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
