using App_de_banco;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Banco accountNumber;
            int addDepository;

            Console.Write("Informe o numero da conta: ");
            int accountNum = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome da conta: ");
            string name = Console.ReadLine();

            Console.Write("Tem saldo para depositar? (Y/N): ");
            char choose = char.Parse(Console.ReadLine());

            if (choose == 'y' || choose == 'Y')
            {
                accountNumber = new Banco(0, name);
                Console.Write("Qual valor voce quer depositar?: ");
                addDepository = int.Parse(Console.ReadLine());
                accountNumber.AddDeposity(addDepository);
                Console.WriteLine();
                Console.WriteLine(accountNumber);

            }
            else if (choose == 'n' || choose == 'N')
            {
                accountNumber = new Banco(0, name);
                Console.WriteLine();
                Console.WriteLine(accountNumber);
            }

            //accountNumber = new Banco(0, name); corrigir aqui pq estava errado
            Console.Write("Qual valor deseja depositar?: ");
            addDepository = int.Parse(Console.ReadLine());
            //accountNumber.AddDeposity(addDepository);

            Console.Write("Qual valor deseja Sacar?: ");
            addDepository = int.Parse(Console.ReadLine());
            //accountNumber.WithDraw(addDepository); corrigir aqui

            Console.WriteLine();
            //Console.WriteLine(accountNumber); corrigir aqui
        }


    }
}
