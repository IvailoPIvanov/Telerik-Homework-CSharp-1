using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4SumOf5Numbers_7
{
    class Program
    {
        static void Main(string[] args)
        {
            short aNumber = short.Parse(Console.ReadLine());
            short bNumber = short.Parse(Console.ReadLine());
            short cNumber = short.Parse(Console.ReadLine());
            short dNumber = short.Parse(Console.ReadLine());
            short eNumber = short.Parse(Console.ReadLine());

            int sum = aNumber + bNumber + cNumber + dNumber + eNumber;

            Console.WriteLine(sum);
        }
    }
}
