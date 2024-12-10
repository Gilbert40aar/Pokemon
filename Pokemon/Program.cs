using Pokemon.utils;

namespace Pokemon
{
    class Program
    {
        public static string? FileName = "pokemon.txt";
        static void Main(string[] args)
        {
            string[] _menu = { 
                "1. Add Pokemon", 
                "2. See All Pokemons", 
                "3. Find Pokemon", 
                "4. Edit Pokemon", 
                "5. Delete Pokemon",
                "6. Exit Program"};
            new FileHandler(FileName);
            new DrawMenu(1, 1, 80, 25, "Pokemon Index");
            new MenuChoices(_menu);
            FileHandler.CreateFile();
            MenuChoices.SetupMenuChoices();
            DrawMenu.MakeMenu();

            Console.ReadKey();
        }
    }
}
