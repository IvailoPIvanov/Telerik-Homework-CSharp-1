using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5BiggestOf3_5
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);

                if(secondNumber > thirdNumber)
                {
                    Console.WriteLine(secondNumber);
                    
                    if(firstNumber > thirdNumber)
                    {
                        Console.WriteLine(firstNumber);
                    }
                }
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        } 
    }
}
