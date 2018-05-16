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
            string[] names = {"Вася ", "Машина ", "Земля ", "Утка ", "Диван ", "Компьютер "};
            string[] hows = {"быстро ", "счастливо ", "томно ", "редко ", "шумно ", "остро "};
            string[] moves = {"платит", "бегает", "танцует", "отдыхает", "смотрит",  "ест"};
            Random rand = new Random();
            int max = rand.Next(6);
            Console.WriteLine(names[max] + hows[max] + moves[max]);
            Console.ReadLine();
        }
    }
}
