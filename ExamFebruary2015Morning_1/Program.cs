using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFebruary2015Morning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());

            double numberE = 500.00;
            double numberD = numberA * numberB;
            double resul = numberD / numberE;
            double a = resul * numberC;

            Console.WriteLine("{0:F1}",a);

        }
    }
}
