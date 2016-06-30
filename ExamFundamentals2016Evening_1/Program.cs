using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFundamentals2016Evening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberT = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberS = double.Parse(Console.ReadLine());
            double numberN = double.Parse(Console.ReadLine());

            double result =( numberT * numberB) *( numberS * numberN);

            if (result % 2 == 0)
            {
                double even = result * 376439;
                Console.WriteLine("{0:F3}", even);
            }
            else
            {
                double odd = result / 7;
                Console.WriteLine("{0:F3}", odd);
            }
        }
    }
}
