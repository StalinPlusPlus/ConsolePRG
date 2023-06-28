namespace ConsolePRG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                    break;
            }
        }

        private static void Menu()
        {
            Console.WriteLine("\t---Главное меню---");
            Console.WriteLine("1. Профиль");
            Console.WriteLine("2. Битва");
            Console.WriteLine("3. Магазин");
            Console.WriteLine("0. Выход");
            
        }
    }
}