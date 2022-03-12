using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_Game.src
{
    class Testing
    {
        Coords PlayerPos;
        public void SetupScreen()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            PlayerPos = new Coords();
            PlayerPos.x = PlayerPos.y = 0;
        }

        public void Init()
        {
            SetupScreen();
            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                DisplayScreen();
                if (keyInfo.Key == ConsoleKey.W)
                {
                    if (PlayerPos.y > 0) PlayerPos.y--;
                }
                else if(keyInfo.Key == ConsoleKey.S)
                {
                    if(PlayerPos.y >= 0) PlayerPos.y++;

                }
                else if (keyInfo.Key == ConsoleKey.A)
                {
                    if (PlayerPos.x > 0) PlayerPos.x--;

                }
                else if (keyInfo.Key == ConsoleKey.D)
                {
                    if (PlayerPos.x >= 0) PlayerPos.x++;

                }
                DisplayScreen();
            }
        }

        private void DisplayScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(PlayerPos.x, PlayerPos.y);
            Console.WriteLine("#");
        }
    }

    public class Coords 
    {
        public int x;
        public int y;
    }
}
