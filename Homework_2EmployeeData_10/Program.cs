using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2EmployeeData_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First name;");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Age");
            sbyte age = sbyte.Parse(Console.ReadLine());
            
            Console.WriteLine("General(m or f)");
            char gender = char.Parse(Console.ReadLine());
            while (gender != 'm' && gender != 'f')
            {
                Console.WriteLine("{0} is not a valid sex", gender);
                Console.WriteLine("Please enter f or m");
                gender = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Personal ID number");
            uint personalNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine("Uniqie employee number");
            ulong employeeNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine("Employee Name: {0} {1}",firstName,lastName);
            Console.WriteLine("Employee Age and Gender: {0} {1}",age,gender);
            Console.WriteLine("Employee Personal ID: {0}",personalNumber);
            Console.WriteLine("Employee unique number: {0}",employeeNumber);
        }
    }
}
