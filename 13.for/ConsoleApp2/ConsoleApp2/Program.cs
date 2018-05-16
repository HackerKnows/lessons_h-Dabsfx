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
            string s = Console.ReadLine();
            int dlina = s.Length;
            char letter = s[0];
            char letterl = s[dlina - 1];
            if (letter == letterl)
            {
                Console.WriteLine("Мне нравится!");
            }
            else
            {
                Console.WriteLine("Мне не нравится!");
             }
            Console.ReadLine();
        }
    }
}
