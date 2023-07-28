using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoTesteTarefa
{
    internal class UsedProduct :Product
    {

        public DateTime ManufacturyDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manufacturyDate) : base (name, price)
        {
            ManufacturyDate = manufacturyDate;
        }
        public override string PriceTag()
        {
            return Name + "(Usado) $" + Price.ToString("F2") + "(Data de fabricaçao" + ManufacturyDate.ToString("dd/mm/yyyy") + ")";
        }
    }
}
