using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Player
    {
        private ConsoleColor backGroundColor = ConsoleColor.DarkRed;
        private ConsoleColor foregroundColor = ConsoleColor.Yellow;
        private char playerChar = 'O';

        private const char moveUp = 'w';
        private const char moveDown = 's';
        private const char moveLeft = 'a';
        private const char moveRight = 'd';

        private int currX = 1;
        private int currY = 1;

        private int prevX = 1;
        private int prevY = 1;

        public Player()
        {
            Draw();
        }

        public void Move()
        {
            char presKey = Console.ReadKey(true).KeyChar;

            switch (presKey)
            {
                case moveUp:
                    currY--;
                    break;
                case moveDown:
                    currY++;
                    break;
                case moveLeft:
                    currX--;
                    break;
                case moveRight:
                    currX++;
                    break;
                default:
                    break;
            }

            Draw();
        }

        private void Draw()
        {
            Console.ResetColor();
            Console.SetCursorPosition(prevX, prevY);
            Console.Write(' ');

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGroundColor;
            Console.SetCursorPosition(currX, currY);
            Console.Write(playerChar);

            prevX = currX;
            prevY = currY;
        }

    }
}
