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

            bool isPrime = true;
            if ((nNumber <= 0) || (nNumber == 1))
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; Math.Pow(i, 2) <= nNumber; i++)
                {
                    if (nNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isPrime ? "true" : "false");
        }
    }
}