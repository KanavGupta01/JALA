using System;

namespace _3.Built_In_Data_Types_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a program on converting Float to Decimal type and print in console
            float f = 50.5959F;

            decimal d = Convert.ToDecimal(f);

            Console.WriteLine(d);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
