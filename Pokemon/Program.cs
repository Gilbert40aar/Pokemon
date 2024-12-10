using Pokemon.utils;

namespace Pokemon
{
    class Program
    {
        public static string? FileName = "pokemon.txt";
        static void Main(string[] args)
        {
            new FileHandler(FileName);
            FileHandler.CreateFile();
            new DrawMenu(1,1,80,25,"Pokemon Index");
            DrawMenu.MakeMenu();
            Console.ReadKey();
        }
    }
}
