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
            int[] numbers = { 1, -2, 3, -1, 2, -3, 1, -4, 5, -8, };
            int d = 0;
            Console.WriteLine("'Введите номер массива от 1 до 10");
            int x = int.Parse(Console.ReadLine());
            x = x - 1;
            Console.WriteLine("замените значение массива");
            int y = int.Parse(Console.ReadLine());
            numbers[x] = y;
            for (int z = 0; z<=9; z++) 
            {
                Console.WriteLine(numbers[d]);
                d = d + 1;
            }
            Console.ReadLine();
        }
    }
}
