using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics_2.Services;
using Generics_2.Entities;
using System.Globalization;

namespace Generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            CalculationService calculationService = new CalculationService();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                string name = s[0];
                double price = double.Parse(s[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            Console.Write("Max: ");
            Console.WriteLine(calculationService.max(list));
        }
    }
}
