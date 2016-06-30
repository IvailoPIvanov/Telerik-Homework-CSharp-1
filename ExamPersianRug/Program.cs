using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPersianRug
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int width = 2 * a + 1;

            for (int row = 0; row < a; row++)
            {
                Console.Write(new string('#', row));
                Console.Write('\\');
                int space = width - row - row - 1 - 1 - b - b;

                if (space >= 2)
                {
                    Console.Write(new string(' ', b));
                    Console.Write('\\');
                    Console.Write(new string('.', space - 2));
                    Console.Write('/');
                    Console.Write(new string(' ', b));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 1 - 1));
                }
              
                Console.Write('/');
                Console.Write(new string('#', row));


                Console.WriteLine();
            }
            Console.WriteLine(new string('#', a) + 'X' + new string('#', a));

            for (int row = a - 1; row >= 0; row--)
            {
                Console.Write(new string('#', row));
                Console.Write('/');
                int space = width - row - row - 1 - 1 - b - b;

                if (space >= 2)
                {
                    Console.Write(new string(' ', b));
                    Console.Write('/');
                    Console.Write(new string('.', space - 2));
                    Console.Write('\\');
                    Console.Write(new string(' ', b));
                }
                else
                {
                    Console.Write(new string(' ', width - row - row - 1 - 1));
                }
               
                Console.Write('\\');
                Console.Write(new string('#', row));

                Console.WriteLine();
            }
        }
    }
}
