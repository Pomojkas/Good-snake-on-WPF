using System;
using System.Collections.Generic;

namespace Good_snake_on_WPF
{
    public class GameState
    {
        public int Rows { get; }
        public int Columns { get; }
        public GridValue[,] Grid { get; }
        public Direction Direction { get; private set; }
        public int Score { get; private set; }
        public bool GaneOver { get; private set; }

        private readonly LinkedList<Position> snakePositions = new LinkedList<Position>();
        private readonly Random random = new Random();

        public GameState(int rows, int columns) 
        {
            Rows = rows; 
            Columns = columns;
            Grid = new GridValue[rows, columns];
            Direction = Direction.Right;
        }

        private void AddSnake()
        {

        }
    }
}
