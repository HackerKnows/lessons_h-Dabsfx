using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите игру, которую желаете купить. 1 - GTA V. 2. - NFS 51. 3. - StarCraft");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш баланс?");
            int cash = int.Parse(Console.ReadLine());
            int lost = cash - 1000;
            
                if (1000 < cash)
                {
                    Console.WriteLine("Покупка совершена. Остаток на балансе - " + lost);
                  if (choose == 1)
                  {
                     Console.WriteLine("Была куплена игра - GTA V");
                  }
                    else if (choose == 2)
                    {
                        Console.WriteLine("Была куплена игра - NFS 51");
                    }
                    else if (choose ==3)
                    {
                    Console.WriteLine("Была куплена игра - StarCraft");
                    }
                }
              
                else
                {
                Console.WriteLine("У вас недостаточно средств на балансе.");
                }
            Console.ReadLine();
        }
    }
}
