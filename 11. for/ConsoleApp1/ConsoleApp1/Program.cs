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
            int max = 0;
            for (int i=1; i <=10; i++)
            {
                Console.WriteLine("Введите расстояние до города №" + i);
               int rad = int.Parse(Console.ReadLine());
                if (rad>max)
                {
                    max = rad;
                }
            }
            Console.WriteLine("Длина до самого удаленного города: " + max );
            Console.ReadLine();
        }
    }
}
