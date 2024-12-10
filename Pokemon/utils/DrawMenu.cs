using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.utils
{
    class DrawMenu
    {
        // Here will we put our properties
        public static int X { get; set; }
        public static int Y { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string? Title { get; set; }

        public DrawMenu(int _x, int _y, int _width, int _height, string? _title)
        {
            X = _x;
            Y = _y;
            Width = _width;
            Height = _height;
            Title = _title;
        }
        /// <summary>
        /// This method will be drawing the menu for us.
        /// </summary>
        public static void MakeMenu()
        {
            SetCorners();
            DrawHorizontalLines();
            DrawVerticalLines();
            SetTitle();
        }

        public static void SetCorners()
        {
            string? topLeftCorner = "╔", topRightCorner = "╗", bottomRigtCorner = "╝", bottomLeftCorner = "╚";

            Console.SetCursorPosition(X, Y);
            Console.WriteLine(topLeftCorner);
            Console.SetCursorPosition(Width - X, Y);
            Console.WriteLine(topRightCorner);
            Console.SetCursorPosition(X, Height - Y);
            Console.WriteLine(bottomLeftCorner);
            Console.SetCursorPosition(Width - X, Height - Y);
            Console.WriteLine(bottomRigtCorner);
        }

        public static void DrawHorizontalLines()
        {
            string? horizontalLine = "═";
            for (int i = X; i < Width - 2; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.WriteLine(horizontalLine);
                Console.SetCursorPosition(X + i, Height - Y);
                Console.WriteLine(horizontalLine);
            }
        }

        public static void DrawVerticalLines()
        {
            string? verticalLine = "║";
            for (int i = Y; i < Height - 2; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(verticalLine);
                Console.SetCursorPosition(Width - X, Y + i);
                Console.WriteLine(verticalLine);
            }
        }

        public static void SetTitle()
        {
            int length = Title.Length;
            Console.SetCursorPosition((Width - length) / 2, Y + 1);
            Console.WriteLine(Title);
        }
    }
}
