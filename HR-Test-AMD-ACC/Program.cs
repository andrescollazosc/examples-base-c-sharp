using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_Test_AMD_ACC
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = new int[6, 6] {
            //{-9, -9, -9, 1, 1, 1},
            //{0, -9, 0, 4, 3, 2},
            //{-9, -9, -9, 1, 2, 3},
            //{0, 0, 8, 6, 6, 0},
            //{0, 0, 0, -2, 0, 0},
            //{0, 0, 1, 2, 4, 0}
            //};

            int[,] array = new int[6, 6] {
            {1, 1, 1, 0, 0, 0},
            {0, 1, 0, 0, 0, 0},
            {1, 1, 1, 0, 0, 0},
            {0, 0, 2, 4, 4, 0},
            {0, 0, 0, 2, 0, 0},
            {0, 0, 1, 2, 4, 0}
            };

            int result = FillNewMatrix(array, 0);

            Console.WriteLine(result);


        }

        private static List<int> resultList = new List<int>();

        private static int FillNewMatrix(int[,] array, int newLine = 0, int newColumn = 0)
        {
            int[,] newMatrix = new int[3, 3];
            int resultSum = 0;            

            for (int line = 0; line < 3; line++)
            {
                for (int col = 0; col < 3; col++)
                {
                    newMatrix[line, col] = array[line + newLine, col + newColumn];

                    if (line != 1 || (col != 0 && col != 2))
                    {
                        resultSum = resultSum + newMatrix[line, col];
                    }
                }
            }

            resultList.Add(resultSum);

            if (newColumn == 3 && newLine != 3) {
                newLine++;
                newColumn = -1;
                FillNewMatrix(array, newLine, newColumn + 1);
            }
            else if (newLine != 3 || newColumn != 3)
            {
                FillNewMatrix(array, newLine, newColumn + 1);
            }

            return resultList.Max();
        }

    }
}
