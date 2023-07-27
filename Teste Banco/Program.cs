using System;
using System.Net.Http.Headers;
using Teste_Banco;
using Teste_Banco.Script;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(100,"kaiki",5000,500);
            //Console.WriteLine(account.Balance);
            //account.Balance = 200;

            //upcasting

            Account acc1 = new Account(1800, "k", 259);
            BusinessAccount abacc = new BusinessAccount(1002, "l", 0, 100);
            acc1 = abacc;

            Account acc2 = new BusinessAccount(1, "o", 1, 1);

            //downcast

            BusinessAccount acc4 = acc2 as BusinessAccount; // accout se tornou businesaccount

            BusinessAccount acc5 = acc4 as BusinessAccount;

            Account acc3 = new SavingAccount(1, "a", 0, 1);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc6 = acc3 as BusinessAccount;
                acc6.Loan(100);
                Console.WriteLine("Loan");
                    

            }
            if(acc3 is SavingAccount)
            {
                SavingAccount acc7 = acc3 as SavingAccount;
                acc7.UpdateBalance();
                Console.WriteLine("update");
            }

            Account acc9 = new Account(3000, "e", 1000);
            Account acc10 = new SavingAccount(1006, " r", 80, 0.01);

            acc9.WithDraw(10);
            acc10.WithDraw(10);

            Console.WriteLine(acc9.Balance);
            Console.WriteLine(acc10.Balance);
        }
    }
}