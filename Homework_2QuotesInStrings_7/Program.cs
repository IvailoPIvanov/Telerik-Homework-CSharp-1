using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2QuotesInStrings_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string useA = @"The ""use"" of quotations causes difficulties.";
            string useB = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("{0}\n{1}",useA,useB);

        }
    }
}
