using Pokemon.programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.utils
{
    class FileHandler
    {
        public static string? FileName { get; set; }

        public FileHandler(string? _filename)
        {
            FileName = _filename;
        }

        /// <summary>
        /// This method check if file exists, If file does not exists
        /// then it will be created, else nothing happens
        /// </summary>
        public static void CreateFile()
        {
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }
        }

        public static string? WriteToFile(List<AddPokemon> _pokemons)
        {
            try
            {
                string[] pokemonNames = _pokemons.Select(p => p.Name + "," + p.Type + "," + p.Strength + "," + p.Level).ToArray();
                File.WriteAllLines(FileName, pokemonNames);
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static void ReadFromFile()
        {
            string[] pokemonNames = File.ReadAllLines(FileName);
            List<AddPokemon> pokemons = [];
            for (int i = 0; i < pokemonNames.Length; i++)
            {
                string pokemonName = pokemonNames[i];
                string[] values = pokemonName.Split(',');
                string _name = values[0];
                string _type = values[1];
                int _strength = int.Parse(values[2]);
                int _level = int.Parse(values[3]);
                pokemons.Add(new AddPokemon()
                {
                    Name = _name,
                    Type = _type,
                    Strength = _strength,
                    Level = _level,
                });
            }
            Program.pokemons = pokemons;
        }
    }
}
