using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8600
#pragma warning disable CS8604
namespace kait.cogs
{
    internal class Shablon3
    {
        public static void Program(string[] args)
        {
            bool b = true;
            List<string> list = new List<string>();
            while (b == true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Заполнить инвентарь");
                Console.WriteLine("2. Проверить инвентарь");
                Console.WriteLine("3. Отправиться в поход");
                string console = Console.ReadLine();
                switch (console)
                {
                    case "1":
                        Console.WriteLine("Напишите обьект:");
                        string l = Console.ReadLine();
                        list.Add(l);
                        Console.WriteLine("Нажмите на любую кнопку для выхода...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Список обьектов:");
                        int i = 1;
                        foreach (string s in list)
                        {
                            Console.WriteLine($"{i}. {s}");
                            i++;
                        }
                        Console.WriteLine("Нажмите на любую кнопку для выхода...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Отправляемся в поход!");
                        Console.WriteLine("Список обьектов:");
                        int t = 1;
                        foreach (string s in list)
                        {
                            Console.WriteLine($"{t}. {s}");
                            t++;
                        }
                        b = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестный аргумент!");
                        break;
                }
            }
        }
    }
}
