using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
namespace kait.cogs
{
    class Player
    {
        public string Name;
        public int Health;
    }
    internal class Shablon9
    {
        public static void Program(string[] args)
        {
            void TakeDamage(string Name, int Damage, int Health)
            {
                Console.WriteLine($"{Name} takes {Damage} damage! Current health: {Health - Damage}");
            }
            Player player = new Player();
            player.Name = "Igor";
            player.Health = 100;
            TakeDamage(player.Name, 20, player.Health);
        }
    }
}

