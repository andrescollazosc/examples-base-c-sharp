using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arrayBi = new List<List<int>> {
                new List<int> { 1, 0, 5 },
                new List<int> { 1, 1, 7 },
                new List<int> { 1, 0, 3 },
                new List<int> { 2, 1, 0 },
                new List<int> { 2, 1, 1 },
            };

            var result = dynamicArray(2, arrayBi);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static List<int> copyResult = new List<int>() { 0, 0 };

        public static List<int> dynamicArray(int n, List<List<int>> queries) {
            List<int> result = new List<int>() { 0, 0 };
            int lastAnswer = 0;
            int xId = 0;

            foreach (var item in queries)
            {
                for (int i = 0; i < 1; i++) {
                    if (item[i] == (int)QueryEnum.QuetyOne)
                    {
                        xId = FindPost(item[1], lastAnswer, n);
                        result[xId] = item[2];
                        copyResult[xId] = item[2];
                    }

                    if (item[i] == (int)QueryEnum.QuetyTwo)
                    {
                        xId = FindPost(item[1], lastAnswer, n);
                        var newPos = item[2] % item.Count;
                        lastAnswer = copyResult[xId];
                        result[newPos] = lastAnswer;
                    }
                }
            }

            return result;
        }

        private static List<int> FindQueryTwo(List<int> resultList) {
            return null;
        }

        private static int FindPost(int posX, int lastAnswer, int n) {
            return (posX ^ lastAnswer) % n;
        }

        

    }

    public enum QueryEnum { 
        QuetyOne = 1,
        QuetyTwo = 2
    }

}
