using System;

namespace _8.For_Foreach_Loop_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // By using Array write the program using For and Foreach loop in c#
            string[] skills = { "ASP.NET", "C#", "HTML", "CSS", "JavaScript", "SQL Server" };

            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}
