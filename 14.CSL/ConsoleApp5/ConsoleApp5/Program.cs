using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 };
            int sum = 0;
            for (int x = 0; x <= number.Length-1; x++)
            {
                sum = sum+ number[x];
            }
            Console.WriteLine(sum);
            sum = sum % 2;
            Console.WriteLine(sum);
            if (sum == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            Console.ReadLine();
        }
    }
}
