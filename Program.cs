using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo6
{
    internal class Program
    {
        static void Main(string[] args)
          
        {
            int maxWith = 50;
            int maxHeight = 30;
            Console.Clear();
            // Ve khung
            for (int i = 0; i <= maxWith; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("+");
                Console.SetCursorPosition(i, maxHeight);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("+");
            }
            for (int i = 0; i <= maxHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("+");
                Console.SetCursorPosition(maxWith, i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("+");

            }
            Console.BackgroundColor = ConsoleColor.Black;
            int x = (maxWith / 2) + 1;
            int y = (maxHeight / 2) + 1;
            Console.SetCursorPosition(y, x);
            Console.Write("0");
            int newX = x;
            int newY = y;
            // phim dichuey
            while (true)
            {
                Console.SetCursorPosition(newX, newY);
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Write(" ");
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        newY--;
                        break;
                    case ConsoleKey.DownArrow:
                        newY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        newX--;
                        break;
                    case ConsoleKey.RightArrow:
                        newX++;
                        break;
                }
                Console.SetCursorPosition(newX, newY);
                Console.Write("0");

                // dk game over
                if (newX >=maxWith || newX<=1 || newY <=1 || newY>=maxHeight)
                {
                    break;
                }
            }
            Console.Clear();

            Console.WriteLine("Game Over");


            Console.ReadKey();

        }
       
    }


}