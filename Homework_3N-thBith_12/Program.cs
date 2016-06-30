using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3N_thBith_12
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int bit = int.Parse(Console.ReadLine());

            Console.WriteLine((number >> bit) & 1);
        }
    }
}
