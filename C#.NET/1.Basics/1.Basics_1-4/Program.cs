using System;

namespace _1.Basics_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare a variable of data type int  with name empID
            int empID;

            // 2. Declare a variable of data type string with name  empName  
            string empName;

            // 3. Assign a value 5 for the  empId  variable and print the value of  empId on console
            empID = 5;

            //4. Assign a value "Puja" for the empName  variable  and print the value of  empId  on console
            empName = "Puja";
            Console.WriteLine(empID);

            // Wait for keyboard press before closing terminal window
            Console.ReadKey();
        }
    }
}