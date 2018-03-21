using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост и вес");
            int large = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            if ((large - 100) < weight)
            {
                Console.WriteLine("Вам следует поправиться");
            }
            else
            {
                Console.WriteLine("Вам следует похудеть");
            }
            Console.ReadLine();
        }
    }
}
