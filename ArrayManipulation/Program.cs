using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 3] {
                { 1, 6, 3 },
                { 4, 8, 7 },
                { 6, 9, 1 },
                { 2, 6, 2 }
            };

            int n = 10;
            var test = arrayManipulation(n, mat);

            Console.ReadLine();
        }

        static long arrayManipulation(int n, int[,] queries)
        {
            int[,] finalArray = getInitialMat(n, queries);
            int[,] finalArray1 = new int[queries.Length,n];

            for (int rows = 0; rows < queries.Length; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (rows > 0)
                    {
                        finalArray1[rows,cols] = finalArray[rows - 1,cols] + finalArray[rows,cols];
                    }
                    else
                    {
                        finalArray1[rows,cols] = finalArray[rows,cols];
                    }
                }
            }

            for (int i = 0; i < queries.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(" " + finalArray1[i,j]);
                }
                Console.WriteLine();
            }

            return 5; // findMax(finalArray, n);
        }

        static int[,] getInitialMat(int n, int[,] queries)
        {
            int[,] finalArray = new int[queries.Length, n];
            int aux = 0;

            for (int rows = 0; rows < queries.GetLength(0); rows++)
            {
                int a = queries[rows,0];
                int b = queries[rows,1];
                int k = queries[rows,2];
                int range = (b - a);

                for (int cols = 0; cols < n; cols++)
                {
                    if ((cols + 1) >= a && (cols + 1) <= b)
                    {
                        finalArray[rows,cols] = k;
                    }
                    else
                    {
                        finalArray[rows,cols] = 0;
                    }
                }

                if (rows > 1)
                {
                    if (queries[rows,0] < queries[rows - 1,0])
                    {
                        aux = queries[rows,0];
                    }
                    else
                    {
                        aux = queries[rows - 1,0];
                    }
                }

                if ((aux - 1) < 0)
                {
                    aux = 0;
                }
                else
                {
                    aux = aux - 1;
                }

                k = queries[0,2];

                Console.WriteLine("New K value: " + k);

                for (int newCol = 0; newCol < aux; newCol++)
                {
                    finalArray[rows,newCol] = k;
                }

                Console.WriteLine();
                Console.WriteLine("less number: " + aux);
                Console.WriteLine("Current row: " + rows);
                Console.WriteLine();

            }

            return finalArray;
        }

        /*static int[,] completeMatrix(int queries[,], int row) {
            int aux = 0;

            if (row > 1) {
                if (queries[row,0] < queries[row - 1,0]) {
                    aux = queries[row,0];
                } else {
                    aux = queries[row - 1,0];
                }
            }

            if ((aux - 1) < 0) {
                aux = 0;
            } else {
                aux = aux -1;
            }
        }*/

        //static int findMax(int[,] mat, int n)
        //{
        //    int maxElement = 0; // Integer.MIN_VALUE;
        //    for (int i = 0; i < mat.Length; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (mat[i,j] > maxElement)
        //            {
        //                maxElement = mat[i, j];
        //            }
        //        }
        //    }

        //    return maxElement;
        //}



    }
}
