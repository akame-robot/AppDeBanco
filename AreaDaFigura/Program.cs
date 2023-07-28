using AreaDaFigura;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("radius?: ");
            double radius = int.Parse(Console.ReadLine());
            Console.Write("color?: ");
            string colour = Console.ReadLine();
            list.Add(new Circule(radius, colour));

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}