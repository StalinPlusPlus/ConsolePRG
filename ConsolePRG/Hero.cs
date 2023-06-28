
namespace ConsolePRG
{
    internal class Hero
    {
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; } 
        public string Name { get; set; }
        public int Gold { get; set; }
        private List<Item> inventory = new List<Item>();
        public Hero(string name) 
        {
            Name = name;
            Health = 100;
            Armor = 100;
            Damage = 10;
            Gold = 0;
        }

        public void Profile()
        {
            Console.Clear();
            Console.WriteLine("Имя героя: " + Name);
            Console.WriteLine("HP: " + Health);
            Console.WriteLine("Броня: " + Armor);
            Console.WriteLine("Урон: " + Damage);
            Console.WriteLine("Золото: " + Gold);
            Console.WriteLine();
            Console.WriteLine("0. Главное меню");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
                return;
        }

        public void Inventory()
        {
            Console.Clear();
            if (inventory.Count == 0)
                Console.WriteLine("Инвентарь пуст!");
            Console.WriteLine();
            Console.WriteLine("1. Выбрать предмет");
            Console.WriteLine("0. Главное меню");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
                return;
        }
    }
}
