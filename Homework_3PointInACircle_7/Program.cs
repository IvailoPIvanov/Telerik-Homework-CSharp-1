using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3PointInACircle_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double yNumber = double.Parse(Console.ReadLine());
            double xNumber = double.Parse(Console.ReadLine());
            double kNumber = Math.Sqrt((yNumber * yNumber) + (xNumber * xNumber));

            Console.WriteLine((kNumber <= 2 ? "yes" : "no") + " {0:F2}",kNumber);


        }
    }
}
