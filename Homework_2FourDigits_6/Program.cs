using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2FourDigits_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int dNumber = number % 10;
            int cNumber = (number / 10) % 10;
            int bNumber = (number / 100) % 10;
            int aNumber = (number / 1000) % 10;

            int sumNumber = aNumber + bNumber + cNumber + dNumber;

            Console.WriteLine("{0}", sumNumber);
            Console.WriteLine("{0}{1}{2}{3}", dNumber, cNumber, bNumber, aNumber);
            Console.WriteLine("{0}{1}{2}{3}", dNumber, aNumber, bNumber, cNumber);
            Console.WriteLine("{0}{1}{2}{3}", aNumber, cNumber, bNumber, dNumber);
        }
    }
}
