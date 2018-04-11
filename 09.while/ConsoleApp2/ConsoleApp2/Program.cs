using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double num = double.Parse(Console.ReadLine());
            while (true)
            {
                num = num / 3;
                if (num == 1)
                {
                    Console.WriteLine("Данное число является степенью тройки");
                    break;
                }
               else if (num < 1)
                {
                    Console.WriteLine("Данное число не является степенью тройки");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
