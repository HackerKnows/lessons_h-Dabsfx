﻿using System;
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
            int nomer = s.Length;
            int dlina = nomer - 1;
            for (int i = 1; i <= nomer; i++)
            {
                Console.WriteLine(s[dlina]);
                dlina = dlina - 1;
            }
            Console.ReadLine();
        }
    }
}
