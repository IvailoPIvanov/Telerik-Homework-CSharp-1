using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2UnicodeCharacter_4
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            {
                int num = 42;
                Console.WriteLine("This is in Hexadeximal : {0:X}",num);

                char sim = '\u002A';
                Console.WriteLine("This is char : {0}",sim); 


            }
        }
    }
}
