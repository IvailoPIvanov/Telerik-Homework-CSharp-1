using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3PrimeCheck_8
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte nNumber = sbyte.Parse(Console.ReadLine());


            if (nNumber < 1 || nNumber > 100)
            {
                Console.WriteLine("false");
            }
            else
            { Console.WriteLine("true"); }
        }
    }
}
