using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteHell
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = { 765, 341, 1, -3, 0, 13, -200, 23 };
            for (int x = 0; x <= numbers.Length - 1; x++) 
            {
                numbers[x] = numbers[x] / 5;
                Console.WriteLine(numbers[x]);
            }
            Console.ReadLine();
        }
    }
}