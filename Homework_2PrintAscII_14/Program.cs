using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2PrintAscII_14
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (byte counter = 33; counter <= 126; counter++)
            {
                Console.Write((char)counter);
            }
            Console.WriteLine();
        }
    }
}
