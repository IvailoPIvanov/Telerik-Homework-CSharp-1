using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2ComparingFloats_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (Math.Abs(firstNumber - secondNumber) < eps)
            {
                Console.WriteLine("true");
            }
            else if (Math.Abs(firstNumber - secondNumber) >= eps)
            {
                Console.WriteLine("false");

            }
        }
    }
}
