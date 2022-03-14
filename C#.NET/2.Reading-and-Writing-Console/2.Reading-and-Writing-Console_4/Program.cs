using System;

namespace _2.Reading_and_Writing_Console_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 . Declare a 2 strings as input and contacenate with another string with the both Strings and get Output
            string firstname;
            string lastname;

            Console.Write("Enter firstname: ");
            firstname = Console.ReadLine();

            Console.Write("Enter lastname: ");
            lastname = Console.ReadLine();

            string greeting = "Hello " + firstname + " " + lastname;

            Console.Write(greeting);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
