using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;

            while (true)
            {
                time = time + 1;
                Thread.Sleep(1000);
                Console.WriteLine("Количество секунд, прошедших с момента старта программы - " + time);
            }
            Console.ReadLine();
        }
    } 
}
