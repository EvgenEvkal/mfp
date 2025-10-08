using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kait.cogs;
#pragma warning disable CS1633
#pragma warning disable CS8981
namespace kait
{
    internal class main
    {
        static void Main(string[] args)
        {

            bool mods = true;
            while (mods == true)
            {
                Console.Write("Меню запуска\nВыход - 0\nВыберите мод от 1 до 11: ");
                var mode = Convert.ToInt32(Console.ReadLine());
                int number_mode = 0;
                if (number_mode == 0)
                {
                    switch (mode)
                    {
                        case 0:
                            Console.WriteLine("Выходим из программы");
                            mods = false;
                            break;
                        case 1:
                            number_mode = 1;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon1.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 2:
                            number_mode = 2;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon2.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 3:
                            number_mode = 3;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon3.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 4:
                            number_mode = 4;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon4.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 5:
                            number_mode = 5;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon5.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 6:
                            number_mode = 6;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon6.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 7:
                            number_mode = 7;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon7.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 8:
                            number_mode = 8;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon8.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 9:
                            number_mode = 9;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon9.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 10:
                            number_mode = 10;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon10.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                        case 11:
                            number_mode = 10;
                            Console.Clear();
                            Console.WriteLine($"==========================MODE {mode}======================");
                            Shablon11.Program(args);
                            Console.WriteLine($"===========================================================");
                            Console.WriteLine($"Для выхода в меню нажмите любую клавишу");
                            Console.ReadKey();
                            Console.Clear();
                            number_mode = 0;
                            break;
                    }
                }
            }
        }
    }
}
