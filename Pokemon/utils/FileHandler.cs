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
    }
}
