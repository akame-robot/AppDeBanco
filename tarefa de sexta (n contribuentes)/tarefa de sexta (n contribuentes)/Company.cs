using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_de_sexta__n_contribuentes_
{
    internal class Company : TaxPayer
    {
        public int NumberOfWorkers { get; set; }

        public Company() { }
        public Company(string name, double anualIncome, int numberOfWorkers) : base(name,anualIncome)
        {
            NumberOfWorkers = numberOfWorkers;
        }
        public override double Taxes()
        {
           if (NumberOfWorkers > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
