using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum; 

            Console.WriteLine("Сумма вклада:");
            sum = Convert.ToDouble(Console.ReadLine());

            if (sum < 100)
            {
                Console.WriteLine("много");
            }
        }
    }
}
