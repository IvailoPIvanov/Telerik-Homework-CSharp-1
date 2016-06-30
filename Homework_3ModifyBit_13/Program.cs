using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3ModifyBit_13
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong n = ulong.Parse(Console.ReadLine());
            uint p = uint.Parse(Console.ReadLine());
            uint v = uint.Parse(Console.ReadLine());

            ulong mask = (ulong)1 << (int)p;
            ulong bit = ((ulong)n & (ulong)mask) >> (int)p;

            if (bit != v)
            {
                n = (n ^ mask);
            }
            Console.WriteLine(n);

        }
    }
}

