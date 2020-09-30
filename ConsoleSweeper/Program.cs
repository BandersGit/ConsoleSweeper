using System;


namespace ConsoleSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrid g1 = new SweeperGrid();

            for (int x = 0; x < g1.grid.GetLength(0); x++)
            {   
                System.Console.WriteLine();

                for (int y = 0; y < g1.grid.GetLength(1); y++)
                {
                    Console.Write(g1.grid[x,y]);
                    Console.Write("  ");
                }
            }

            Console.ReadLine();
        }
    }
}
