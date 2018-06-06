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
            int x = 60;
            int[] number = new int[18];
            for (int i = 0; i < number.Length - 1; i++)
            {
                number[i] = x;
               Console.WriteLine(number[i]);
                x = x - 3;
            }
            Console.ReadLine();
        }
    }
}
