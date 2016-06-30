using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4NumberComparer_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double aNumber = double.Parse(Console.ReadLine());
            double bNumber = double.Parse(Console.ReadLine());

            if ( aNumber < bNumber)
            {
                Console.WriteLine(bNumber);
            }
            else
            {
                Console.WriteLine(aNumber);
            }
        }
    }
}
