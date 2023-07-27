using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Banco.Script
{
    internal class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(int num, string holder, double balance, double interestRate) : base (num, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            Balance -= amount;
        }
    }
}
