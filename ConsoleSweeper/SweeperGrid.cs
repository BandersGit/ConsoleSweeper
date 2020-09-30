using System;


namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        public int[,] grid = new int[10, 10];

        static Random generator = new Random();

        public SweeperGrid()
        {
          for (int x = 0; x < grid.GetLength(0); x++)
          {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                  grid [x,y] = 9;
            }
          }

          for (int i = 0; i < 10; i++)
          {
              grid [generator.Next(0,10), generator.Next(0,10)] = 10;
          }

        }

        public bool CheckPosition(int x, int y)
        {
          return true;
        }

    }
}
