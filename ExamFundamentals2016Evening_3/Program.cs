using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFundamentals2016Evening_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int numA, a;
            int numB, b;
            numA = int.Parse(Console.ReadLine());
            numB = int.Parse(Console.ReadLine());

            int sum = 0;

            for (a = 1; a <= numA; a++)
            {
                for (b = 1; b <= numB; b++)
                {


                    if (numA % a == 0 & numB % b == 0)
                    {
                        if (a % 2 == 0 & b % b == 0)
                        {

                        }
                        else
                        {
                           sum = a + b;

                           

                        }
                       
                    }


                }
                
            }
            Console.WriteLine("{0}", sum);
        }
       
        
    }
    
    
}
