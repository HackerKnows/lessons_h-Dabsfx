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
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int x = 0; x <= 5; x++)
            {
                sum = sum + number[x];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
