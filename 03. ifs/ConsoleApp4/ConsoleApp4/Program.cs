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
            Console.WriteLine("Ваш баланс?");
            int have = int.Parse(Console.ReadLine());
            int spend = 100;
            int waste = have - spend;
            if (have > spend)
               
            {
                Console.WriteLine("Ваш остаток - " + waste);
            }
          else
            {
          Console.WriteLine("На счету недостаточно средств");
            }
            Console.ReadLine();
        }
    }
}
