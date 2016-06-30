using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFundamentals2016Evening_3_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = a; i <= b; i++)
            {
                for (int c = 1; c <= i; c++)
                {
                    if (c % 2 != 0 && i % c == 0)
                        result += c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
