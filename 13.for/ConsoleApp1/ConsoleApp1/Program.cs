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
            string s = Console.ReadLine();
            int dlina = s.Length;
            for (int i=0; i <=dlina-1; i++)
            {
                char letter = s[i];
                if (letter == 'и')
                {
                    Console.WriteLine("В этом слове есть буква и");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
