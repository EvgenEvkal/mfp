using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
namespace kait.cogs
{
    class Item
    {
        public string Title;
        public int Weight;
        public int Cost;
    }
    internal class Shablon8
    {
        public static void Program(string[] args)
        {
            void Describe(string Title, int Weight, int Cost)
            {
                Console.WriteLine($"{Title}(Weight: {Weight}, Cost: {Cost} gold)");
            }
            Item item = new Item();
            item.Title = "Apple";
            item.Weight = 1;
            item.Cost = 3;
            Describe(item.Title, item.Weight, item.Cost);
        }
    }
}
