using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_de_sexta__n_contribuentes_
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }
        public Individual(string name, double anualIncome, double healthExp) : base (name, anualIncome) 
        {
            HealthExpenditures = healthExp;
        }

        public override double Taxes()
        {
            if (AnualIncome <= 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
