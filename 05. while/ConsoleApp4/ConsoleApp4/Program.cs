using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты - супергерой. Твоя задача - вызволить принцессу/принца из плена Всемирной Сети, куда она/он попала, по неосторожности ткнув в рекламный баннер. В самом начале ты только-только получил известие о неприятности, и стоишь перед выбором:");
            Console.WriteLine("1. Поиграть в Доту");
            Console.WriteLine("2. Узнать, на каком сайте она застряла");
            int choose1 = int.Parse(Console.ReadLine());
            if (choose1 == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Environment.Exit(0);
            }
            else if (choose1 == 2)
            {
                Console.WriteLine("Следующий фрейм.");
            }
            Console.WriteLine("Рассказывается, что принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob. Варианты поведения:");
            Console.WriteLine("1. Послушаться совета в адресе сайта и поиграть в Доту (конец игры, проигрыш - другой хакер спас принцессу");
            Console.WriteLine("2. Перейти на сайт");
            Console.WriteLine("3. Обновить антивирус, а потом перейти на сайт");
            int choose2 = int.Parse(Console.ReadLine());
            if (choose2 <= 2)
            {
                Console.WriteLine("ты проиграл");
                Environment.Exit(0);
            }
            else if (choose2 == 3)
            {
                Console.WriteLine("Следующий фрейм.");
            }
            Console.WriteLine("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2? Варианты поведения:");
            Console.WriteLine("1. Проверить исходный код Капча-Монстра ");
            Console.WriteLine("2. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            Console.WriteLine("3. Ответить монстру: 6");
            int choose3 = int.Parse(Console.ReadLine());
            if (choose3 >= 2)
            {
                Console.WriteLine("Ты проиграл");
                Environment.Exit(0);
            }
            else if (choose3 == 1)
            {
                Console.WriteLine("Следующий фрейм.");
            }
            Console.WriteLine("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне! Варианты поведения:");
            Console.WriteLine("1. Круто, пойду попробую так в своей программе! (конец игры, проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо)");
            Console.WriteLine("2. Ответить монстру: 6");
            Console.WriteLine("3. Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра");
            int choose4 = int.Parse(Console.ReadLine());
            if (choose4 <= 2)
            {
                Console.WriteLine("ты проиграл");
                Environment.Exit(0);
            }
            else if (choose4 == 3)
            {
                Console.WriteLine("Следующий фрейм.");
            }
            Console.WriteLine("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2 ) * 2? Варианты поведения:");
            Console.WriteLine("1. Ответить монстру: 8");
            Console.WriteLine("2. Герою лень считать, и он идет в Доту");
            int choose5 = int.Parse(Console.ReadLine());
            if (choose5 == 2)
            {
                Console.WriteLine("Ты проиграл");
                Environment.Exit(0);
            }
            else if (choose5 == 1)
            {
                Console.WriteLine("Следующий фрейм.");
            }
            Console.WriteLine("Капча-Монстр обиженно сопит: 2Как ты догадался ? Я же спрятал скобки!, отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0.Файл - лекарство можно найти здесь: C:.Antivirus.cure.exe. Варианты действий:");
            Console.WriteLine("1. Отправить лекарство принцессе по почте и пойти в Доту (конец игры, проигрыш - у нее сломался компьютер, она не может получить твой файл! принцессу спасает другой хакер)");
            Console.WriteLine("2. Записать лекарство на флешку и пойти к принцессе/принцу домой");
            int choose6 = int.Parse(Console.ReadLine());
            if (choose6 == 1)
            {
                Console.WriteLine("Ты проиграл");
                Environment.Exit(0);
            }
            else if (choose6 == 2)
            {
                Console.WriteLine("Победа!");
            }
            Console.ReadLine();
        }
    } }
