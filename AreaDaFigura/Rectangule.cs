using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDaFigura
{
    internal class Rectangule : Shape
    {
        public double Height { get; set; }
        public double Wight { get; set; }

        public Rectangule(double height, double wight, string color) : base(color)
        {
            Height = height;
            Wight = wight;
        }
        public override double Area()
        {
            return Height * Wight;
        }
    }
}
