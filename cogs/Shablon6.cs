using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kait.cogs
{
    internal class Shablon6
    {
        public static void Program(string[] args)
        {
            string IsEven(int arg)
            {
                if (arg % 2 == 0)
                {
                    return "Четное";
                }
                else
                {
                    return "Нечетное";
                }
            }
            Console.WriteLine(IsEven(10));
            Console.WriteLine(IsEven(15));
        }
    }
}
