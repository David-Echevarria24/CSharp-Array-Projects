using System.Data;

namespace Arrays4;

class Program
{
    static void Main() // Displaying a table
    {
        int[,] grid = new int[3, 3]; //Intializing the grid

        for (int row = 0; row < grid.GetLength(0); row++) //Getting row
        {
            for (int col = 0; col < grid.GetLength(1); col++) //Getting Column
            {
                grid[row, col] = row * 3 + col;
                Console.Write($"{grid[row, col]}"); //Process the array in a two dimensional
            }
            Console.WriteLine();
        }
        
    }
}
