using System;
using TarefaAulaHeranca;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Console.WriteLine("numero de empregados: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine($"empregado #{i} info:");
                Console.WriteLine("tercerizado (Y/N)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("nome: ");
                string name = Console.ReadLine();
                Console.Write("horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("valor por hora: ");
                double valuePHour = double.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employeeList.Add(new OutsourceEmployee(name, hours, valuePHour, additionalCharge));
                }
                else
                {
                    employeeList.Add(new Employee(name, hours, valuePHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("pagamentos: ");
            foreach(Employee emp in employeeList)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2")}");
            }
        }
    }
}