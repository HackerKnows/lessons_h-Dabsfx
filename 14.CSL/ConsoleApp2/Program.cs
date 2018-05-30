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
            int[] numbers = { 1, -2, 3, -1, 2, -3, 1, -4, 5, -8, };
            Console.WriteLine("'Введите номер массива от 1 до 10");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("замените значение массива");
            int y = int.Parse(Console.ReadLine());
            numbers[x] = y;
        }
    }
}
