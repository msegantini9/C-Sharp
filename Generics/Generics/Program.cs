using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            int n;

            do 
            {
                Console.Write("How many values? ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 10);

            for(int i=0; i<n; i++)
            {
                printService.addValue(int.Parse(Console.ReadLine()));
            }

            printService.print();

            Console.WriteLine("First: " + printService.first());
        }
    }
}
