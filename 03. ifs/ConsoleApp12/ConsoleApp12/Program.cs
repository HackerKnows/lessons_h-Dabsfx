using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты у входа в пещеру, которую охраняет огр.У тебя есть варианты действий:");
            Console.WriteLine("1. Вступить в бой");
            Console.WriteLine("2. Ты отступаешь");
            Console.WriteLine("3. Подкупаешь огра");
            Console.WriteLine("4. Ищешь обходной путь");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("ты погибаешь, так как огр сильнее");
            }
            else if (choose == 2)
            {
                Console.WriteLine("переносишься в соседнюю локацию");
            }
            else if (choose == 3)
            {
                Console.WriteLine("он пропускает тебя внутрь");
            }
            else if (choose ==4 )
            {
                Console.WriteLine("по пути тебя грабят бандиты");
            }
            Console.ReadLine();
          } 
    }
}
