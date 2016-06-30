using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4CompanyInfo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comnpany name:");
            string companyName = Console.ReadLine();

            Console.WriteLine("Company addres:");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Phone number:");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Fax number:");
            string faxNumber = Console.ReadLine();

            Console.WriteLine("Web Site:");
            string web = Console.ReadLine();

            Console.WriteLine("Manager firs name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Manager last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Manager age:");
            sbyte age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("mager phone:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("{0}",companyName);
            Console.WriteLine("Adress: {0}",companyAddress);
            Console.WriteLine("Tel. {0}",phonenumber);
            Console.WriteLine("Fax: {0}",faxNumber);
            Console.WriteLine("Web site: {0}",web);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,managerPhone);
        }
    }
}
