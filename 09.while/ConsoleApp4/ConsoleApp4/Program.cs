using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            Console.WriteLine("Введите пройденный путь");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите весь путь");
            double y = double.Parse(Console.ReadLine());
            while (true)
            {
                day = day + 1;
                x = x + x / 10;
                if (x/y  >= 1)
                {
                    Console.WriteLine("Количество дней, за которое спортмен пробежал расстояние - " + day);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
