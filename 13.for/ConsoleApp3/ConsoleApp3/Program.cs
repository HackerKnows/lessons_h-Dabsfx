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
            string s = Console.ReadLine();
            int dlina = s.Length;
            int j = 0;
            for (int i = 0; i <= dlina - 1; i++)
            {
                char letter = s[i];
                if (letter == 'ж')
                {
                    j = j + 1;
                }
            }
            Console.WriteLine("количество букв ж вэтом слове -  " + j);
            Console.ReadLine();
        }
    }
}
