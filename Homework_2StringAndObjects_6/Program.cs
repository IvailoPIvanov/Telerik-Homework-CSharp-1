using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2StringAndObjects_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string hi = "Hello";
            string world = " World";
            object sum = hi + world;
            string result = (string) sum;
            Console.WriteLine(result);
        }
    }
}
