using MoveOnBoardGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Board
    {
        private int topCorner = 5;
        private int leftCorner = 5;
        private int height = 20;
        private int width = 60;
        private ConsoleColor borderBackgroundColor = ConsoleColor.DarkRed;
        private ConsoleColor borderForegroundColor = ConsoleColor.Yellow;

        private ConsoleColor stoneBackgroundColor = ConsoleColor.DarkMagenta;
        private ConsoleColor stoneForegroundColor = ConsoleColor.Green;

        private char borderChar = 'X';
        private double percentOfStoneObstacles = 0.02;

        private char stoneChar = 'S';

        private List<AvailableField> availableFieldsOnBoard = new List<AvailableField>();

        public Board()
        {
            CompleteAvailableFields();
            GenerateRandomStoneObstacles();
        }

        public void Draw()
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.ForegroundColor = borderForegroundColor;
            Console.BackgroundColor = borderBackgroundColor;

            //górna krawędź
            Console.SetCursorPosition(topCorner, leftCorner);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }

            //krawędzie boczne
            for (int i = 1; i < height - 1; i++)
            {
                //lewa
                Console.SetCursorPosition(topCorner, i + leftCorner);
                Console.Write(borderChar);

                //prawa
                Console.SetCursorPosition(width - 1 + topCorner, i + leftCorner);
                Console.Write(borderChar);
            }

            //dolna krawędź
            Console.SetCursorPosition(topCorner, height - 1 + leftCorner);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }

            //Ryswowanie kamieni
            Console.ForegroundColor = stoneForegroundColor;
            Console.BackgroundColor = stoneBackgroundColor;

            List<AvailableField> listOfStone = availableFieldsOnBoard.Where(af => af.TypeOfObstacle == TypeOfObstacle.Stone).ToList();
            foreach (AvailableField item in listOfStone)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(stoneChar);
            }

            Console.ResetColor();
        }

        public CollisionType CollisionDetect(int x, int y)
        {
            AvailableField availableField = availableFieldsOnBoard
                                            .FirstOrDefault(af => af.X == x && af.Y == y);

            if (availableField == null)
                return CollisionType.BorderCollision;

            if (availableField.TypeOfObstacle == TypeOfObstacle.Stone)
                return CollisionType.StoneCollision;

            return CollisionType.NoCollision;
        }

        private void CompleteAvailableFields()
        {
            for (int x = topCorner + 1; x <= width + topCorner - 2; x++)
            {
                for (int y = leftCorner + 1; y <= height + leftCorner - 2; y++)
                {
                    AvailableField availableField = new AvailableField();
                    availableField.X = x;
                    availableField.Y = y;
                    availableField.TypeOfObstacle = TypeOfObstacle.None;

                    availableFieldsOnBoard.Add(availableField);
                }
            }
        }

        public AvailableField GetRandomAvailableField()
        {
            Random random = new Random();

            int randomNumnber = random.Next(0, availableFieldsOnBoard.Count);

            AvailableField availableField = availableFieldsOnBoard[randomNumnber];

            return availableField;
        }

        private void GenerateRandomStoneObstacles()
        { 
            int countOfStoneObstacles = (int)(height * width * percentOfStoneObstacles);

            Random random = new Random();

            List<AvailableField> listForStone = availableFieldsOnBoard
                .Where(af => af.TypeOfObstacle == TypeOfObstacle.None)
                .OrderBy(af => random.Next())
                .Take(countOfStoneObstacles)
                .ToList();

            foreach (var item in listForStone)
            {
                item.TypeOfObstacle = TypeOfObstacle.Stone;
            }
        }

    }
}
