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
                if (number[i] < 0 && number[i + 1] < 0)
                {
                    Console.WriteLine (number[i] + ", " + number[i+1]);
                    break;
                }
                else if (number[i]  > 0 && number[i + 1] > 0)
                {
                    Console.WriteLine(number[i] + ", " + number[i + 1]);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}