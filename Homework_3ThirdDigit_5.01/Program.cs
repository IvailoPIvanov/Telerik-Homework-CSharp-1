using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3ThirdDigit_5._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int length = number.Length;

            if (length < 3)
            {
                Console.WriteLine("false 0");
            }
            else
            {
                int position = length - 3;
                if (number[position] == '7')
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false {0}",number[position]);
                }
            }
        }
    }
}
