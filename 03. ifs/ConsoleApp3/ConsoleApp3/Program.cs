using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина стороны a?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина стороны b?");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина стороны c?");
            int c = int.Parse(Console.ReadLine());
            if (c*c == (a * a) + (b * b))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным");
            }
            Console.ReadLine();
        }
    }
}
