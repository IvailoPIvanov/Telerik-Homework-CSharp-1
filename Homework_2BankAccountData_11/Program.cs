using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2BankAccountData_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivailo";
            // yes no need for this :))
            string middleName = "Petrov";
            string lastName = "Ivanov";
            // yes i dream for it :) 
            string bankName = "DSK";
            string iban = "STSA9300";

            ulong firstCardNumber = 12345678901234;
            double firstCardBalance = 3756456.12D;

            ulong secondCardNumber = 43210987654321;
            double secondCardBalance = 2975645.45D;

            ulong thirdCardNumber = 11111111111111;
            double thirdCardBalamce = 3123759.59D;

            double balance = firstCardBalance + secondCardBalance + thirdCardBalamce;

            Console.WriteLine("Bank account of: {0} {1}",firstName,lastName);
            Console.WriteLine("Bank: {0} IBAN: {1}",bankName,iban);
            Console.WriteLine("Balance in bill: {0} lv.",balance);
            Console.WriteLine("First Card Number:{0}\nBalance: {1} lv.",firstCardNumber,firstCardBalance);
            Console.WriteLine("Second Card Number:{0}\nBalance: {1} lv.",secondCardNumber,secondCardBalance);
            Console.WriteLine(" Third Card Number:{0}\nBalance: {1} lv.",thirdCardNumber,thirdCardBalamce);
        }
    }
}
