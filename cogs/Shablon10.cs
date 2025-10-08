using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8604
namespace kait.cogs
{
    internal class Shablon10
    {
        class Player1
        {
            public string Name;
            public int LVL;
            public int HP;
            public int HP_MAX;
            public int ATAKA;
            public int ZACHITA;
            public int gold;
            public int OPIT;
            public int Heal(int player_hp, int HP)
            {
                if (player_hp + HP <= 100)
                {
                    return player_hp + HP;
                }
                else
                {
                    return 100;
                }
            }
            public int TakeDamage(int player_hp, int Damage)
            {
                if (player_hp - Damage <= 0)
                {
                    return 0;
                }
                else
                {
                    return player_hp - Damage;
                }
            }
            static public int GainExperience(int player_exp, int vrag_exp, int index)
            {
                int NEW_PLAYER_EXP = 0;
                switch (index)
                {
                    case -1:
                        if (player_exp - vrag_exp > 0)
                        {
                            NEW_PLAYER_EXP = player_exp - vrag_exp;
                        }
                        else
                        {
                            NEW_PLAYER_EXP = 0;
                        }
                        break;
                    case 1:
                        NEW_PLAYER_EXP = vrag_exp;
                        break;
                }
                return NEW_PLAYER_EXP;
            }
            public System.Collections.Generic.List<int> LevelUp(int player_exp, int player_lvl)
            {
                List<int> list = new List<int>();
                int new_lvl;
                int new_exp;
                int exp_lvl_up = Convert.ToInt32(Math.Pow(4, player_lvl + 1));
                if (player_exp - exp_lvl_up >= 0)
                {
                    //1 - new lvl , 2 - new exp
                    new_lvl = player_lvl + 1;
                    new_exp = player_exp - exp_lvl_up;
                    list.Add(new_lvl);
                    list.Add(new_exp);
                }
                else
                {
                    new_lvl = player_lvl;
                    new_exp = player_exp;
                    list.Add(new_lvl);
                    list.Add(new_exp);
                }
                return list;
            }
            static public void PrintStats(string Name, int Lvl, int HP, int ATAKA, int ZACHITA, int gold, int OPIT)
            {
                Console.WriteLine($"""
                    Статистика персонажа:
                    Имя: {Name}
                    Уровень: {Lvl}
                    Здоровье: {HP}
                    Атака: {ATAKA}
                    Защита: {ZACHITA}
                    Золото: {gold}
                    Опыт: {OPIT}
                    """
                );
            }
        }
        class VRAG
        {
            public string Name;
            public int HP;
            public int HP_MAX;
            public int ATAKA;
            public int ZACHITA;
            public int gold;
            public int OPIT;
            public int Heal(int player_hp, int HP)
            {
                if (player_hp + HP <= 100)
                {
                    return player_hp + HP;
                }
                else
                {
                    return 100;
                }
            }
            public int TakeDamage(int player_hp, int Damage)
            {
                if (player_hp - Damage <= 0)
                {
                    return 0;
                }
                else
                {
                    return player_hp - Damage;
                }
            }
        }
        public static void Program(string[] args)
        {
            Console.Clear();
            Player1 player = new Player1();
            Console.Write("Введите имя: ");
            player.Name = Console.ReadLine();
            player.LVL = 1;
            player.HP = 100;
            player.HP_MAX = 100;
            player.ATAKA = 7;
            player.ZACHITA = 9;
            player.gold = 0;
            player.OPIT = 0;
            bool takt = true;
            List<string> list = new List<string>();
            List<string> values = new List<string>();
            values.Add("Меч уровня 1");
            values.Add("Меч уровня 2");
            values.Add("Меч уровня 3");
            values.Add("Щит уровня 1");
            values.Add("Щит уровня 2");
            values.Add("Щит уровня 3");
            values.Add("Зелье востановления");
            while (takt == true)
            {
                Console.Clear();
                Console.Write("""
                    Меню:
                    1.Статус
                    2.Инвентарь
                    3.Магазин
                    4.Поиск боя
                    5.Выход
                    Выберите действие: 
                    """
                );
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Player1.PrintStats(player.Name, player.LVL, player.HP, player.ATAKA, player.ZACHITA, player.gold, player.OPIT);
                        Console.WriteLine("Введите любую кнопку для выхода...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        if (list.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Инвентарь пуст");
                            Console.WriteLine("Введите любую кнопку для выхода...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            int l = 1;
                            foreach (string elsement in list)
                            {
                                Console.WriteLine($"{l}. {elsement}");
                                l++;
                            }
                            Console.WriteLine("Введите любую кнопку для выхода...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("""
                            Список действий
                            1.Покупка предметов
                            2.Продажа предметов
                            3.Просмотр ассортимента
                            Выберите действие: 
                            """
                        );
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.Clear();
                                int i = 1;
                                foreach (string value in values)
                                {
                                    Console.WriteLine($"{i}. {value}");
                                    i++;
                                }
                                Console.Write("Выберите действие: ");
                                switch (Convert.ToInt32(Console.ReadLine()))
                                {
                                    case 1:
                                        Console.Clear();
                                        bool l = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Меч уровня 1")
                                            {
                                                l = true;
                                            }
                                        }
                                        if (l == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 5)
                                            {
                                                player.gold -= 5;
                                                list.Add("Меч уровня 1");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Не хватает {5 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case 2:
                                        Console.Clear();
                                        bool l1 = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Меч уровня 2")
                                            {
                                                l1 = true;
                                            }
                                        }
                                        if (l1 == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 10)
                                            {
                                                player.gold -= 10;
                                                list.Add("Меч уровня 2");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Не хватает {10 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case 3:
                                        Console.Clear();
                                        bool l2 = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Меч уровня 3")
                                            {
                                                l2 = true;
                                            }
                                        }
                                        if (l2 == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 15)
                                            {
                                                player.gold -= 15;
                                                list.Add("Меч уровня 3");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Не хватает {15 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case 4:
                                        Console.Clear();
                                        bool l3 = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Щит уровня 1")
                                            {
                                                l3 = true;
                                            }
                                        }
                                        if (l3 == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 5)
                                            {
                                                player.gold -= 5;
                                                list.Add("Щит уровня 1");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Нехватает {5 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case 5:
                                        Console.Clear();
                                        bool l4 = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Щит уровня 2")
                                            {
                                                l4 = true;
                                            }
                                        }
                                        if (l4 == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 10)
                                            {
                                                player.gold -= 10;
                                                list.Add("Щит уровня 2");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Не хватает {10 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case 6:
                                        Console.Clear();
                                        bool l5 = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Щит уровня 3")
                                            {
                                                l5 = true;
                                            }
                                        }
                                        if (l5 == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 15)
                                            {
                                                player.gold -= 15;
                                                list.Add("Щит уровня 3");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Не хватает {5 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case 7:
                                        Console.Clear();
                                        bool l6 = false;
                                        foreach (string element in list)
                                        {
                                            if (element == "Зелье востановления")
                                            {
                                                l5 = true;
                                            }
                                        }
                                        if (l6 == false)
                                        {
                                            Console.WriteLine("Проверяем баланс...");
                                            if (player.gold >= 30)
                                            {
                                                player.gold -= 30;
                                                list.Add("Зелье востановления");
                                                Console.WriteLine("Успешная покупка!");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Не хватает {30 - player.gold} монет!");
                                            }
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Данный предмет уже есть в инвентаре");
                                            Console.WriteLine("Введите любую кнопку для выхода...");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Такого элемента нету в магазине!");
                                        Console.WriteLine("Введите любую кнопку для выхода...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                }
                                break;
                            case 2:
                                Console.Clear();
                                if (list.Count == 0)
                                {
                                    Console.WriteLine("Инвентарь пуст");
                                    Console.WriteLine("Введите любую кнопку для выхода...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Инвентарь");
                                    int lp = 1;
                                    foreach (string element in list)
                                    {
                                        Console.WriteLine($"ID: {lp} | NAME: {element}");
                                        lp++;
                                    }
                                    Console.Write("Введите ID елемента: ");
                                    int ip = Convert.ToInt32(Console.ReadLine());
                                    if (ip - 1 < list.Count())
                                    {
                                        switch (list[ip - 1])
                                        {
                                            case "Меч уровня 1":
                                                player.gold += 4;
                                                list.Remove("Меч уровня 1");
                                                break;
                                            case "Меч уровня 2":
                                                player.gold += 9;
                                                list.Remove("Меч уровня 2");
                                                break;
                                            case "Меч уровня 3":
                                                player.gold += 14;
                                                list.Remove("Меч уровня 3");
                                                break;
                                            case "Щит уровня 1":
                                                player.gold += 4;
                                                list.Remove("Щит уровня 1");
                                                break;
                                            case "Щит уровня 2":
                                                player.gold += 9;
                                                list.Remove("Щит уровня 2");
                                                break;
                                            case "Щит уровня 3":
                                                player.gold += 14;
                                                list.Remove("Щит уровня 3");
                                                break;
                                            case "Зелье востановления":
                                                list.Remove("Зелье востановления");
                                                player.gold += 15;
                                                break;
                                        }
                                        Console.Clear();
                                        Console.WriteLine("Продано!");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Такого элемента нету!");
                                    }
                                    Console.WriteLine("Нажмите любую кнопку для выхода...");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            case 3:
                                Console.Clear();
                                int k = 1;
                                foreach (string value in values)
                                {
                                    int l = 1; //0 - False; 1 - True
                                    if (list.Count == 0)
                                    {
                                        Console.WriteLine($"{k}. {value} | Доступно");
                                        k++;
                                    }
                                    else
                                    {
                                        foreach (string el in list)
                                        {
                                            if (el == value)
                                            {
                                                l = 0;
                                                break;
                                            }
                                        }
                                        switch (l)
                                        {
                                            case 0:
                                                Console.WriteLine($"{k}. {value} | Недоступно");
                                                k++;
                                                break;
                                            case 1:
                                                Console.WriteLine($"{k}. {value} | Доступно");
                                                k++;
                                                break;
                                        }
                                    }

                                }
                                Console.WriteLine("Нажмите любую кнопку для выхода...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        int p = 1;
                        VRAG vrag = new VRAG();
                        List<string> vrags = new List<string>();
                        vrags.Add("Дракон");
                        vrags.Add("Колдун");
                        foreach (string vrag1 in vrags)
                        {
                            Console.WriteLine($"{p}. {vrag1}");
                            p++;
                        }
                        Console.Write("Выбирете противника: ");
                        int siv = 0; //0 - No , 1 - Yes | Можно заменить на True или False
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                vrag.Name = "Дракон";
                                vrag.HP = 100;
                                vrag.HP_MAX = 100;
                                vrag.ATAKA = 3;
                                vrag.ZACHITA = 3;
                                vrag.gold = 10;
                                vrag.OPIT = 3;
                                siv = 1;
                                break;
                            case 2:
                                vrag.Name = "Колдун";
                                vrag.HP = 100;
                                vrag.HP_MAX = 100;
                                vrag.ATAKA = 7;
                                vrag.ZACHITA = 5;
                                vrag.gold = 20;
                                vrag.OPIT = 5;
                                siv = 1;
                                break;
                            default:
                                siv = 0;
                                break;
                        }

                        switch (siv)
                        {
                            case 0:
                                Console.WriteLine("Не известный индекс!");
                                Console.WriteLine("Нажмите любую кнопку для выхода...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Начинаем сражение!");
                                Console.WriteLine("Нажмите любую кнопку для начала...");
                                Console.ReadLine();
                                Console.Clear();
                                bool sr = true;
                                int vs = 0;
                                int ps = 0;
                                Console.WriteLine("Вы начинаете!");
                                int pv = 0; //0 - player , 1 - vrag
                                int r = 1;
                                Console.WriteLine("Нажмите любую кнопку для начала хода...");
                                Console.ReadLine();
                                while (sr == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Раунд {r}");
                                    if (pv == 0)
                                    {
                                        Console.WriteLine("""
                                            Список действий:
                                            1.Атака
                                            2.Защита
                                            3.Использование элемента из инвентаря
                                            Выберите действие: 
                                            """
                                        );
                                        switch (Convert.ToInt32(Console.ReadLine()))
                                        {
                                            case 1:
                                                if (vs != 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine($"{player.Name} атакует и сносит {player.ATAKA} HP!");
                                                    vrag.HP = player.TakeDamage(vrag.HP, player.ATAKA);
                                                    Console.WriteLine($"У {vrag.Name} {vrag.HP} HP!");
                                                }
                                                else
                                                {
                                                    if (vrag.ZACHITA < player.ATAKA)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"{player.Name} атакует и сносит {player.ATAKA - vrag.ZACHITA} HP!");
                                                        vrag.HP = player.TakeDamage(vrag.HP, player.ATAKA - vrag.ZACHITA);
                                                        Console.WriteLine($"У {vrag.Name} {vrag.HP} HP");
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"{player.Name} атакует но не наносит урон!");
                                                    }
                                                }
                                                ps = 1;
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine($"{player.Name} защищается!");
                                                ps = 2;
                                                break;
                                            case 3:
                                                Console.Clear();
                                                if (list.Count() > 0)
                                                {
                                                    Console.WriteLine("Инвентарь");
                                                    int lp1 = 1;
                                                    foreach (string element in list)
                                                    {
                                                        Console.WriteLine($"ID: {lp1} | NAME: {element}");
                                                        lp1++;
                                                    }
                                                    Console.Write("Введите ID елемента: ");
                                                    int ip = Convert.ToInt32(Console.ReadLine());

                                                    if (ip - 1 < list.Count())
                                                    {
                                                        switch (list[ip - 1])
                                                        {
                                                            case "Меч уровня 1":
                                                                player.ATAKA = 9;
                                                                break;
                                                            case "Меч уровня 2":
                                                                player.ATAKA = 12;
                                                                break;
                                                            case "Меч уровня 3":
                                                                player.ATAKA = 15;
                                                                break;
                                                            case "Щит уровня 1":
                                                                player.ZACHITA = 12;
                                                                break;
                                                            case "Щит уровня 2":
                                                                player.ZACHITA = 15;
                                                                break;
                                                            case "Щит уровня 3":
                                                                player.ZACHITA = 17;
                                                                break;
                                                            case "Зелье востановления":
                                                                player.HP = player.Heal(player.HP, 100);
                                                                list.Remove("Зелье востановления");
                                                                break;
                                                        }
                                                        Console.Clear();
                                                        Console.WriteLine("Выбрано!");
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Инвентарь пуст!");
                                                    }
                                                    ps = 3;
                                                }
                                                break;
                                        }
                                        pv = 1;
                                        if (player.HP <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{player.Name} погибает!");
                                            player.OPIT = Player1.GainExperience(player.OPIT, vrag.OPIT, -1);
                                            player.HP = 100;
                                            sr = false;
                                        }
                                        else if (vrag.HP <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{vrag.Name} погибает!");
                                            player.OPIT = Player1.GainExperience(player.OPIT, vrag.OPIT, 1);
                                            List<int> spis = player.LevelUp(player.OPIT, player.LVL);
                                            player.OPIT = spis[1];
                                            player.LVL = spis[0];
                                            player.HP = 100;
                                            player.gold += vrag.gold;
                                            sr = false;
                                        }
                                        Console.WriteLine("Нажмите любую кнопку для начала следующего хода...");
                                        Console.ReadLine();
                                        Console.Clear();
                                        Console.WriteLine($"Ход {vrag.Name}");
                                    }
                                    else
                                    {
                                        Random vv = new Random();
                                        int vv1 = vv.Next(1, 4);
                                        switch (vv1)
                                        {
                                            case 1:
                                                if (ps != 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine($"{vrag.Name} атакует и сносит {vrag.ATAKA} HP!");
                                                    player.HP = player.TakeDamage(player.HP, vrag.ATAKA);
                                                    Console.WriteLine($"У {player.Name} {player.HP} HP!");
                                                }
                                                else
                                                {
                                                    if (player.ZACHITA < vrag.ATAKA)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"{vrag.Name} атакует и сносит {vrag.ATAKA - player.ZACHITA} HP!");
                                                        player.HP = player.TakeDamage(player.HP, vrag.ATAKA - player.ZACHITA);
                                                        Console.WriteLine($"У {player.Name} {player.HP} HP");
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"{vrag.Name} атакует но не наносит урон!");
                                                    }
                                                }
                                                vs = 1;
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine($"{vrag.Name} защищается!");
                                                vs = 2;
                                                break;
                                            case 3:
                                                Console.Clear();
                                                Random huv1 = new Random();
                                                int huv = huv1.Next(1, 25);
                                                vrag.HP = vrag.Heal(vrag.HP, Convert.ToInt32(huv));
                                                Console.WriteLine($"{vrag.Name} повысил свое здоровье на {huv} HP!\nТеперь у него {vrag.HP} HP!");
                                                vs = 2;
                                                break;
                                        }
                                        pv = 0;
                                        if (player.HP <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{player.Name} погибает!");
                                            player.OPIT = Player1.GainExperience(player.OPIT, vrag.OPIT, -1);
                                            player.HP = 100;
                                            sr = false;
                                        }
                                        else if (vrag.HP <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{vrag.Name} погибает!");
                                            player.OPIT = Player1.GainExperience(player.OPIT, vrag.OPIT, 1);
                                            List<int> spis = player.LevelUp(player.OPIT, player.LVL);
                                            player.OPIT = spis[1];
                                            player.LVL = spis[0];
                                            player.HP = 100;
                                            player.gold += vrag.gold;
                                            sr = false;
                                        }
                                        Console.WriteLine("Нажмите любую кнопку для начала следующего раунда...");
                                        Console.ReadLine();
                                        Console.Clear();
                                        r++;
                                    }

                                }
                                break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        takt = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого елемента нету!");
                        Console.WriteLine("Нажмите любую кнопку для выхода...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

