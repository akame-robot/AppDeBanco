using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaAulaHeranca
{
    internal class OutsourceEmployee : Employee
    {

        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }

        public OutsourceEmployee(string name, int hours, double valuePHours, double additionalCharge) : base(name, hours, valuePHours) // aqui usei o base
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() // chamei o Payment() do employee no que esta no virtual para overrride
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}
