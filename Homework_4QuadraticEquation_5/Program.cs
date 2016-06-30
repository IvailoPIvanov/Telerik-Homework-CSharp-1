using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4QuadraticEquation_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double aNumber, bNumber, cNumber, xNumber,x1,x2;

             aNumber = double.Parse(Console.ReadLine());
             bNumber = double.Parse(Console.ReadLine());
             cNumber = double.Parse(Console.ReadLine());

            xNumber = (bNumber * bNumber - 4 * aNumber * cNumber);
            if (xNumber < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (xNumber == 0)
            {
                xNumber = -bNumber / (2 * aNumber);
                Console.WriteLine(xNumber);
            }
            else
            {
                x2 = (-bNumber - System.Math.Sqrt(xNumber)) / (2 * aNumber);
                x1 = (-bNumber + System.Math.Sqrt(xNumber)) / (2 * aNumber);

                if (x1 < x2)
                {
                    Console.WriteLine("{0:f2}\n{1:f2}",x1,x2);
                   
                }
                else if (x1 > x2)
                {
                   Console.WriteLine("{0:f2}\n{1:f2}", x2, x1);
                }
            }
           
        }
    }
}
