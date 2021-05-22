using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] mat = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        mat[row, col] = 1;
                    }
                    else {
                        mat[row, col] = 0;
                    }
                    Console.Write(" " + mat[row, col]);
                }
                Console.WriteLine();
            }



            Console.WriteLine("Hello World!");
        }
    }
}
