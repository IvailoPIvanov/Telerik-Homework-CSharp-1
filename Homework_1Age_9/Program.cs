using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1Age_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Parse(Console.ReadLine());
            DateTime currentData = DateTime.Today;
            int myAge = currentData.Year - data.Year;
            if (currentData < data.AddYears(myAge)) myAge--;
            Console.WriteLine(myAge);
            Console.WriteLine(myAge + 10);

        }
    }
}
