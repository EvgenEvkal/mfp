using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8604
namespace kait.cogs
{
    internal class Shablon5
    {
        public static void Program(string[] args)
        {
            string GreetUser(string arg)
            {
                Console.WriteLine($"Hello, {arg}!");
                return arg;
            }
            Console.Write("Введите имя: ");
            GreetUser(Console.ReadLine());
        }
    }
}
