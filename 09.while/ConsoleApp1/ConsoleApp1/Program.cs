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
            int each = 0;
            int cows = 0;
            Console.WriteLine("Грузоподъёмность НЛО?");
            int NLO = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Введите массу коровы");
                int lb = int.Parse(Console.ReadLine());
                if (cows < NLO)
                {
                    cows = cows + lb;
                    each = each + 1;
                }
                else
                {
                    Console.WriteLine("Отсек для коров заполнен, взлетаем! Коров на борту - " + each);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
