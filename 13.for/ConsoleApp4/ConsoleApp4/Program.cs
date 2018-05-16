using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] football = { 1, 2, 3, 1, 2, 3, 1, 4, 5, 8, };
            for (int x = 0; x <= football.Length-1; x++)
            {
                if (football[x] < 3)
                {
                    Console.WriteLine("Команда номер - " + x);
                }
            }
            Console.ReadLine();
        }
    }
}
