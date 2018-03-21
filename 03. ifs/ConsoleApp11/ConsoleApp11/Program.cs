using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три целых числа");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x >=y && x>=z)
            {
                Console.WriteLine("Большее число - " + x);
            }
            else
            {
                if (y>=x && y>=z)
                {
                    Console.WriteLine("Большее число - " + y);
                }
                else if (z>=x && z>=y)
                {
                    Console.WriteLine("Большее число - " + z);
                }
            }
            Console.ReadLine();
        }
    }
}
