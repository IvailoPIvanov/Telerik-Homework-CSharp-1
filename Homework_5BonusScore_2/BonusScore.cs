using System;


namespace Homework_5BonusScore_2
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a<=3)
            {

                Console.WriteLine("{0}",a * 10);
            }
            else if (a >=4 && a<=6)
            {
                Console.WriteLine("{0}",a * 100);
            }
            else if (a >=7 && a <= 9)
            {
                Console.WriteLine("{0}",a * 1000);
            }
            else if (a<=0 || a > 9)
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
