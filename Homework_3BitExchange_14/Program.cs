using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3BitExchange_14
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string numbetToBinary = Convert.ToString(number, 2).PadLeft(64, '0');
            var binary = numbetToBinary.ToCharArray();
            Array.Reverse(binary);

            char num1 = binary[3];
            binary[3] = binary[24];
            binary[24] = num1;

            char num2 = binary[4];
            binary[4] = binary[25];
            binary[25] = num2;

            char num3 = binary[5];
            binary[5] = binary[26];
            binary[26] = num3;

            Array.Reverse(binary);
            string num4 = new string(binary);
            long result = Convert.ToInt64(num4, 2);

            Console.WriteLine(result);
        }
    }
}
