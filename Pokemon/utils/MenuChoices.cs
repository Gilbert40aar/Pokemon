using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.utils
{
    class MenuChoices
    {
        public static string[] Entries = { };

        public MenuChoices(string[] _entries)
        {
            Entries = _entries;
        }

        public static void SetupMenuChoices() 
        {
            for (int i = 0; i < Entries.Length; i++)
            {
                Console.SetCursorPosition(DrawMenu.X + 2, DrawMenu.Y + 2 + i);
                Console.WriteLine(Entries[i]);
            }
        }

        public static void Case(string? _choice)
        {
            switch(_choice)
            {
                case "1":
                    DrawPokemonMenu();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    Program.Exit = false;
                    break;
                default:
                    break;

            }
        }

        public static void DrawPokemonMenu()
        {
            Console.Write("What is the name of the pokemon: ");
            string _name = Console.ReadLine();
            Console.Write("What is the type of the pokemon: ");
            string _type = Console.ReadLine();
            Console.Write("What is the strength of the pokemon: ");
            int _strength = int.Parse(Console.ReadLine());
            Console.Write("What is the level of the pokemon: ");
            int _levet = int.Parse(Console.ReadLine());
            Program.pokemons.Add(new programs.AddPokemon()
            {
                Name = _name,
                Type = _type,
                Strength = _strength,
                Level = _levet
            });
        }
    }
}
