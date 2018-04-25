using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int max = 10;
            while (true)
            {
                int number1 = rand.Next(max);
                int number2 = rand.Next(max);
                int number3 = rand.Next(max);
                Console.WriteLine("Чтобы меня закрыть реши задачку:");
                Console.WriteLine("Сколько будет " + number1 + "+" + number2 + "+" + number3 + "=?");
                int answer = int.Parse(Console.ReadLine());
                if (answer == number1+number2+number3)
                {
                    Console.WriteLine("Ну ты и мега-мозг!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Неа! Ну-ка, теперь попробуй  решить другую!");
                }
            }
        }
    }
}
