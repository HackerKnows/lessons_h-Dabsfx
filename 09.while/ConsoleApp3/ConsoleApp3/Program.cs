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
            while (true)
            {
                Console.WriteLine("Введите число");
                int num = int.Parse(Console.ReadLine());
                if (num > 10 && num < 100)
                {
                    Console.WriteLine(num);
                }
                else if (num > 100)
                {
                    Console.WriteLine("Приостановка приложения");
                    Console.ReadLine();
                    break;
                }
             }
        }
    }
}
