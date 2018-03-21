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
            Console.WriteLine("Введите первые координаты от 1 до 8");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторые координаты от 1 до 8");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третьи координаты от 1 до 8");
            int three = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвёртые координаты от 1 до 8");
            int fourth = int.Parse(Console.ReadLine());
            if (first == three || second == fourth)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
