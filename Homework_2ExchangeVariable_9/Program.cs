using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2ExchangeVariable_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int changeNumberOne  = 5;
            int changeNumberTwo = 10;

            Console.WriteLine("{0} {1}",changeNumberOne,changeNumberTwo);

            int changeNumber = changeNumberOne;
            changeNumberOne = changeNumberTwo;
            changeNumberTwo = changeNumber;

            Console.WriteLine("{0} {1}",changeNumberOne,changeNumberTwo); 
        }
    }
}
