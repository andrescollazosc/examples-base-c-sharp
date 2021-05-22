using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> {
                1
            };

            List<int> b = new List<int> {
                100
            };

            Console.WriteLine(getTotalX(a, b));

            Console.ReadLine();
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            var maxValue = a.Max();
            var newMaxValue = maxValue * maxValue;
            List<int> result = new List<int>();

            for (int j = 0; j < a.Count; j++)
            {
                for (int i = 1; i <= b.Max(); i++)
                {
                    if ((i % a[j]) == 0)
                    {
                        result.Add(i);
                    }
                }
            }

            var duplicates = result.GroupBy(x => x).Where(g => g.Count() > 1)
                                        .Select(x => x.Key).ToList();

            return CountInteger(b, duplicates);
        }

        private static int CountInteger(List<int> b, List<int> result)
        {
            List<int> resultInteger = new List<int>();

            for (int i = 0; i < b.Count; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if ((b[i] % result[j]) != 0) {
                        resultInteger.Add(result[j]);
                    }
                }
            }

            var deleteElementsRepeated = resultInteger.GroupBy(x => x).Select(y => y.FirstOrDefault()).ToList();

            var resultEnd = result.Where(x => !deleteElementsRepeated.Contains(x)).ToList();

            return resultEnd.Count;
        }


    }
}
