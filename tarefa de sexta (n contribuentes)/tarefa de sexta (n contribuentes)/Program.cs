using System;
using System.Globalization;
using tarefa_de_sexta__n_contribuentes_;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Insira o numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"contribintes #{i} data: ");
                Console.Write("e uma pessoa fisica ou juridica (f/j)?: ");
                char s = char.Parse(Console.ReadLine());
                Console.Write("nome: ");
                string name = Console.ReadLine();
                Console.Write("rendimento anual: ");
                double income = double.Parse(Console.ReadLine());
                if (s == 'f')
                {
                    Console.Write("gastos em saude: ");
                    double healthincome = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, healthincome));
                }
                else
                {
                    Console.Write("numero de funcionarios: ");
                    int worker = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, worker));
                }

                double sum = 0.0;
                Console.WriteLine();
                Console.WriteLine("impostos pagos: ");
                foreach (TaxPayer taxPayer in list)
                {
                    double tx = taxPayer.Taxes();
                    Console.WriteLine(taxPayer.Name + ": $ " + tx.ToString("F2"));
                    sum += tx;

                }
                Console.WriteLine();
                Console.WriteLine("TOTAL DE IMPOSTOS: $ " + sum.ToString("F2"));

            }
        }
    }
}