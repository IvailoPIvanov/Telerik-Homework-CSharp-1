using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4Circle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            double area = pi * (radius * radius);

            Console.WriteLine("{0:F2} {1:F2}",perimeter,area);
        }
    }
}
