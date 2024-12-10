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
    }
}
