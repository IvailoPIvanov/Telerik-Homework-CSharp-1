using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3DivideBy7And5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 && number % 5 == 0)
            {



                Console.WriteLine("true {0}", number);

            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
