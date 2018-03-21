using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение (x)");
            int x = int.Parse(Console.ReadLine());
                if (x < 4)
            {
                Console.WriteLine("С этими координатами точка попадает в I четверть");
            }
            else
            {
                Console.WriteLine("С этими координатами точка попадает в II четверть");
            }
            Console.ReadLine();
        }
    }
}
