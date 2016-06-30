using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5MultiplicationSign_4
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("+");
            }
            else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            else if ((firstNumber == 0) ||(secondNumber == 0) || (thirdNumber == 0))
            {
                Console.WriteLine("0");
            }
        }
    }
}
