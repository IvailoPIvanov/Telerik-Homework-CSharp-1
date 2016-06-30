using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4CompanyInfo_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phonenumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string web = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phonenumber);
            if (faxNumber == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", faxNumber);
            }
          
            Console.WriteLine("Web site: {0}", web);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
        }

    }
}
