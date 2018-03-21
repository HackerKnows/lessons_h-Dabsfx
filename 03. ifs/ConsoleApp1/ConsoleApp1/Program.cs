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
            int end = win / (all - win);
            Console.WriteLine("Сколько игр ты успел сыграть?" );
            int all = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько из них ты выиграл?" );
            int win = int.Parse(Console.ReadLine());
            int end = win / (all - win);
            Console.WriteLine("Соотношение - " + end);
            Console.ReadLine();
        }
    }
}
