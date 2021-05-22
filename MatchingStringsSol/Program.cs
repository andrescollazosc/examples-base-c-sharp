using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingStringsSol
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringArrays = new string[4]
            {
                "aba", "baba", "aba", "xzxb"
            };

            string[] querysArrays = new string[3]
            {
                "aba", "xzxb", "ab"
            };

            var result = matchingStrings(stringArrays, querysArrays);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadLine();
        }

        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] resultArray = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                string value = queries[i];
                int stringToFind = strings.Where(x => x == value).Count();
                resultArray[i] = stringToFind;
            }

            return resultArray;
        }

    }
}
