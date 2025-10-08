using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
namespace kait.cogs
{
    internal class Shablon7
    {
        class Monster
        {
            public string Name;
            public int Health;
            public int Damage;
        }
        public static void Program(string[] args)
        {
            void Attack(string Name, int Damage)
            {
                Console.WriteLine($"{Name} attacks for {Damage} damage!");
            }
            Monster monster = new Monster();
            monster.Name = "Drakon";
            monster.Damage = 10;
            Attack(monster.Name, monster.Damage);
        }
    }
}
