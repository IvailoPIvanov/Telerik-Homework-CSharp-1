using System;


namespace Homework_5ExchangeIfGreater_1
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if ( a < b)
                {
                Console.WriteLine("{0} {1}", a, b);
                }
            else
            {
                Console.WriteLine("{0} {1}", b, a);
            }
        }
    }
}
