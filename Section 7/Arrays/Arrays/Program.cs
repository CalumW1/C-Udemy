using System;

namespace Arrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        static void Main(string[] args)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] % 2 == 1)
                    {
                        Console.WriteLine("{0}", matrix[i, j]);
                    }
                }
            }
        }
    }
}
