using System;

namespace ConsoleApp_fit_point74
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Example of reversion";

            var words = sentence.Split(" ");

            var resultReverse = ReverseArray(words);
            
            Console.WriteLine(string.Join(' ', resultReverse));
        }

        private static string[] ReverseArray(string[] arrayToBeReversed) {
            string[] reversed = new string[arrayToBeReversed.Length];
            int invertedIndex = arrayToBeReversed.Length - 1;

            for (int i = 0; i < arrayToBeReversed.Length; i++)
            {
                reversed[invertedIndex] = arrayToBeReversed[i];
                invertedIndex--;
            }

            return reversed;
        }
    }
}
