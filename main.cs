using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kait
{
    internal class main
    {
        static void Main(string[] args)
        {

            bool mods = true;
            while (mods == true)
            {
                Console.Write("Меню запуска\nВыход - 0\nВыберите мод от 1 до 10: ");
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
                            Program.Program1(args);
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
                            Program.Program2(args);
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
                            Program.Program4(args);
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
                            Program.Program5(args);
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
                            Program.Program6(args);
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
                            Program.Program7(args);
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
                            Program.Program8(args);
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
                            Program.Program9(args);
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
                            Program.Program10(args);
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
