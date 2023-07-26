using App_de_banco;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco accountNumber = new Banco(0, "name");

            Console.Write("Informe o numero da conta: ");
            accountNumber.AccountRegisNum();

            Console.Write("Informe o nome da conta: ");
            accountNumber.AccountRegisName();

            Console.Write("Tem saldo para depositar? (Y/N): ");
            accountNumber.AddRepository();

            Console.Write("Qual valor deseja depositar?: ");
            accountNumber.AddDeposity();




        }
    }
}