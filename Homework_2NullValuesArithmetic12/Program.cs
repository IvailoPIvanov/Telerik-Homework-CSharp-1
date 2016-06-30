using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2NullValuesArithmetic12
{
    class Program
    {
        static void Main(string[] args)
        {
            int? intVariable = null;
            double? doubVariable = null;

            Console.WriteLine("Int null:{0}",intVariable);
            Console.WriteLine("Double nul:{0}",doubVariable);

             intVariable += 12;
             doubVariable += 12.7;

            Console.WriteLine("Int Number + null:{0}",intVariable);
            Console.WriteLine("Double Number + null:{0}",doubVariable);
            Console.WriteLine("You can't add number to null!");

            intVariable = 12;
            doubVariable = 12.7;
            Console.WriteLine("Number:{0}",intVariable);
            Console.WriteLine("Number:{0}",doubVariable);
            
        }
    }
}
