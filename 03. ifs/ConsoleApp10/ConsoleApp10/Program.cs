using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш возраст?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10 && age < 20)
            {
                Console.WriteLine("Вы подросток");
            }
            else
            {
                Console.WriteLine("Вы не являетесь подростком");
            }
            Console.ReadLine();
        }
    }
}
