using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Квадраты, не превосходящие:");
            int start = 1;
            while (true)
            {
                if (start * start < n)
                {
                    Console.WriteLine(start*start);
                    start = start + 1;
                }
                else
                {
                    break;
                }
             }
            Console.ReadLine();
        }
    }
}
