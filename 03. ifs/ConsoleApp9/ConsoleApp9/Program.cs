using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст и здоровье дракона");
            int old = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            if (old > 150)
            {
                
                if (health > 50)
                {
                  Console.WriteLine("Вам стоит отступить");  
                }
                else
                { 
                    Console.WriteLine("Вам стоит наступать на дракона");
                }
            }
            else
            {
                Console.WriteLine("Вам стоит напасть на дракона");
            }
            Console.ReadLine();
        }
    }
}
