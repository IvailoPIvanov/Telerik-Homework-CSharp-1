using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3Trapezoids_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double aSides =double.Parse(Console.ReadLine());
            double bSides =double.Parse(Console.ReadLine());
            double hSides =double.Parse(Console.ReadLine());

            double area = ((aSides + bSides) / 2) * hSides;

            Console.WriteLine("{0:F7}",area);
        }
    }
}
