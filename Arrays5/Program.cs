namespace Arrays5;

class Program
{
    static void Main()
    {
        int[][] matrix = new int[3][]; // Making arrays of array

        for (int i = 0; i < matrix.Length; i++) //Getting first set of array
        {
            matrix[1] = new int[3]; //Getting second set of array
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = i * 3 + j;
                Console.WriteLine($"{matrix[i][j]}");
            }
        }

        // int[][] matrix1 =
        // {
            // new int[]{0, 1, 2},
            // new int[]{3, 4, 5},
            // new int[]{6, 7, 8, 9}
        // };

    }
}
