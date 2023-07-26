using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App_de_banco
{
    internal class Banco
    {

        public int AccountNum { get; private set; }
        public string AccountName { get; set; }
        public double Depository { get; private set; }

        private char _char;
        private double addDepository;

        public Banco(int accountNum, string accountName)
        {
            AccountNum = accountNum;
            AccountName = accountName;
        }

        public Banco(int num, string name, double depository) : this (num, name)
        {
            AccountNum = num;
        }

        public void AccountRegisNum()
        {
            AccountNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Console.WriteLine(_accountNum);
        }

        public void AccountRegisName()
        {
            AccountName = Console.ReadLine();
            Console.WriteLine();
            //Console.WriteLine(_accountName);
        }

        public void AddRepository()
        {
            _char = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (_char == 'y' || _char == 'Y')
            {
                Depository = 0;
                Console.Write("Qual valor voce quer depositar?: ");
                addDepository = int.Parse(Console.ReadLine());
                Depository += addDepository;
                Console.Clear();
                Console.WriteLine($"Numero da conta: {AccountNum}\n");
                Console.WriteLine($"Nome da conta: {AccountName}\n");
                Console.WriteLine($"Seu deposito: {Depository}\n");
            }
            else if (_char == 'n' || _char == 'N')
            {
                Console.Clear();
                Console.WriteLine($"Numero da conta: {AccountNum}\n");
                Console.WriteLine($"Nome da conta: {AccountName}\n");
                Console.WriteLine($"Seu deposito: {Depository}\n");
            }
        }

        public void AddDeposity()
        {
            addDepository = int.Parse(Console.ReadLine());
            Depository += addDepository;
            Console.WriteLine(Depository);
        }
    }
}
