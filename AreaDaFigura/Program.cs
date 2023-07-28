using AreaDaFigura;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> circule = new List<Shape>();
            List<Shape> rectangule = new List<Shape>();
            Console.WriteLine("escolha a area que quer calcular\n1 - retangulo\n2 - circulo ");
            int area = int.Parse(Console.ReadLine());
            switch (area)
            {
                case 1:
                    Console.Write("height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("weight: ");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("color: ");
                    string color1 = Console.ReadLine(); 
                    rectangule.Add(new Rectangule(height, weight,color1));
                    foreach(Shape rec in rectangule)
                    {
                        Console.WriteLine(rec.Area().ToString("F2"));
                    }

                    break;


                case 2:
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.Write("color?: ");
                    string colour = Console.ReadLine();
                    circule.Add(new Circule(radius, colour));
                    foreach (Shape circules in circule)
                    {
                        Console.WriteLine(circules.Area().ToString("F2"));
                    }
                    break;
            }
        }
    }
}