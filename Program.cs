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
            int maxWith = 30;
            int maxHeight = 10;
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
            


            // toa dodoj ran
            int x = (maxWith / 2) + 1;
            int y = (maxHeight / 2) + 1;
          
            Console.SetCursorPosition(x, y);
            Console.Write("0");
            int newX = x;
            int newY = y;
            // toa do diem
            Random random = new Random();

            int point_x = random.Next(2, maxWith - 2);
            int point_y = random.Next(2, maxHeight - 2);
            if(point_x!=newX && point_y != newY) {
                Console.SetCursorPosition(point_x, point_y);
                Console.Write("*");
            }
            else
            {
                point_x = random.Next(2, maxWith - 2);
                point_y = random.Next(2, maxHeight - 2);
            }
            int index = 0;
           

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
                // dk vacham
                if(newX==point_x && newY == point_y)
                {
                    index++;
                 
                    
                    point_x = random.Next(2, maxWith - 2);
                    point_y = random.Next(2, maxHeight - 2);
                    if (point_x != newX && point_y != newY)
                    {
                        Console.SetCursorPosition(point_x, point_y);
                        Console.Write("*");

                    }
                    else
                    {
                        point_x = random.Next(2, maxWith - 2);
                        point_y = random.Next(2, maxHeight - 2);
                    }

                }
               

            }

            Console.Clear();

            Console.WriteLine("Game Over");


            Console.ReadKey();

        }
       
    }


}