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
            int[] number = { 23, 4545, 45, 2, -16, 765, 341, 1, -3, 0, -10, -15, -13 };
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] < number[i + 1])
                {
                    int x = number[i + 1];
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
