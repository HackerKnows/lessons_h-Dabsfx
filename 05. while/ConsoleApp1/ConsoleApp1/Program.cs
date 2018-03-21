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
            Console.WriteLine("На сколько больше воздуха, чем кислорода?");
            int air = int.Parse(Console.ReadLine());
            Console.WriteLine("Средняя температура?");
            int hot = int.Parse(Console.ReadLine());
            if (air > 20 && hot > 15)
            {
                Console.WriteLine("Планета пригодна для заселения");
            }
            else
            {
                Console.WriteLine("Планета не является пригодной для жизни");
            }
            Console.ReadLine();
        } 
    }
}
