using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2VariableInHexadecimal_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is simple way
            int num = 0XFE;
           if(num == 254)
            {
                Console.WriteLine("{0} True!!!",num);
            }
           else
            {
                // This is unnecessarily 
                Console.WriteLine("False");
            }
        }
    }
}
