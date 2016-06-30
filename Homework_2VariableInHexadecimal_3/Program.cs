using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2VariableInHexadecimal_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexString = "FE";
            int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            if (num == 254)
            {
                Console.WriteLine("{0} True!!", num);
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
