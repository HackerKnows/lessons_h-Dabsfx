using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько игр ты успел сыграть?");
            double all = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько из них ты выиграл?");
            double win = int.Parse(Console.ReadLine());
            double end = win/all;
            Console.WriteLine("Соотношение - " + end);
            Console.ReadLine();
        }
    }
}
