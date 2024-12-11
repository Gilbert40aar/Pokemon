using Pokemon.programs;
using Pokemon.utils;

namespace Pokemon
{
    class Program
    {
        public static string? FileName = "pokemon.txt";
        public static bool Exit = true;
        public static List<AddPokemon> pokemons = new List<AddPokemon>();

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
            FileHandler.ReadFromFile();
            do
            {
                Console.Clear();
                DrawMenu.MakeMenu();
                MenuChoices.SetupMenuChoices();
                Console.WriteLine();
                Console.CursorLeft = 3;
                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();
                MenuChoices.Case(choice);
            } while (Exit);
            FileHandler.WriteToFile(pokemons);
        }
    }
}
