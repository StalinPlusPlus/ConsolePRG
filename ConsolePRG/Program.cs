
namespace ConsolePRG
{
    internal class Program
    {
        static bool newGame = true;
        static string name = "";

        static void Main(string[] args)
        {
            while (true)
            {
                Menu();

                Hero mainHero = new Hero(name);

                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    break;
                else if (number == 1)
                    mainHero.Profile();
                else if (number == 2)
                    mainHero.Inventory();
            }
        }

        private static void Menu()
        {
            if (newGame)
            {
                Console.WriteLine("Введите имя вашего героя: ");
                name = Console.ReadLine();
                newGame = false;
            }
            Console.Clear();
            Console.WriteLine("\t---Главное меню---");
            Console.WriteLine("1. Профиль");
            Console.WriteLine("2. Инвентарь");
            Console.WriteLine("2. Битва");
            Console.WriteLine("4. Магазин");
            Console.WriteLine("0. Выход");

        }
    }
}