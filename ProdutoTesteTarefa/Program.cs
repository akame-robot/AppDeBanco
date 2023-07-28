using ProdutoTesteTarefa;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Product> list = new List<Product>();
            Console.Write("numero de produtos: ");
            int n = int.Parse(Console.ReadLine());
           for(int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Produto #{i} info: ");
                Console.Write("comum, usado ou importado (c/u/i)?: ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = int.Parse(Console.ReadLine());
                if(type == 'c')
                {
                    list.Add(new Product(name, price));

                }
                else if (type == 'u')
                {
                    Console.Write("data de fabricação (dd/mm/yyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));


                }
                else
                {
                    Console.Write("taxa da alfandega: ");
                    double customFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customFee));
                }

                Console.WriteLine();
                Console.WriteLine($"etiqueta de preço:");
                foreach(Product product in list)
                {
                    Console.WriteLine(product.PriceTag());
                }

            }
        }
    }
}