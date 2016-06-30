using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3MoonGravity_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            
            double weightOnMoon = ((double)0.17 * weight);

            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
