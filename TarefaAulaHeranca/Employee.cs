using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaAulaHeranca
{
    internal class Employee
    {

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePHour { get; set; }

        public Employee() 
        {

        }
        public Employee(string name, int hours, double valuePHour) // usando base eu pego esse valor do objeto para usar em outro usando BASE
        {
            Name = name;
            Hours = hours;
            ValuePHour = valuePHour;
        }

        public virtual double Payment() // usando virtual consigo chamar ele usando o override
        {
            return Hours * ValuePHour;
        }
    }
}
