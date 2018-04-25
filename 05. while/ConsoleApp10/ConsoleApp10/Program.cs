using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число");
                int dbl = int.Parse(Console.ReadLine());
                int end = dbl * dbl;
                Console.WriteLine("Квадрат числа - " + end);
            }
            Console.ReadLine();
        }
    }
}
