using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3ThirdDigit_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirdNumber = number / 100;
            if ( thirdNumber % 10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}",thirdNumber);
            }
        }
    }
}
