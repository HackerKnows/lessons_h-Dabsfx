using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -2, 3, -1, 2,- 3, 1, -4, 5, -8, };
            Console.WriteLine("Введите число от 1 до 10");
            int x = int.Parse(Console.ReadLine());
            x = x - 1;
            if (numbers[x] > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else
            {
                Console.WriteLine("Число отрицательное");
            }
            Console.ReadLine();
        }
    }
}
