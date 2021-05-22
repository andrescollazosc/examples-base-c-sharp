using System;
using System.Collections.Generic;

namespace LeftRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = new long[5] {
                1,2,3,4,5
            };

            var result = rotLeft(array, 4);

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            var result1 = rotateLeft1(4, list);

            for (int i = 0; i < result1.Count; i++)
            {
                Console.Write(" " + result1[i]);
            }
        }

            
        private static long[] newArray;

        static long[] rotLeft(long[] a, long d) {
            if (d == 0 || a.Length == 0)
                return a;

            long length = a.Length;
            newArray = new long[length];

            if (d != 0)
            {
                FillNewArray(a, length);
                d--;
                a = newArray;
                newArray = new long[length];
                rotLeft(a, d);
            }

            d = 0;

            return a;
        }

        private static long[] FillNewArray(long[] a, long length) {            
            newArray = new long[length];

            for (long i = 0; i < length; i++)
            {
                if (i == 0) {
                    newArray[length - 1] = a[i];
                }
                else {
                    newArray[i - 1] = a[i];
                }
            }

            return newArray;
        }

        private static int[] RotLeftValidate(int[] a, int d = 0, int newDigit = 1)
        {
            int[] newArray = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    newArray[a.Length - 1] = a[i];
                }
                else
                {
                    newArray[i - 1] = a[i];
                }
            }

            if (newDigit != d)
            {
                newDigit++;
                newArray = RotLeftValidate(newArray, d, newDigit);
            }
            newDigit = 0;

            return newArray;
        }

        private static List<int> newArray1;

        public static List<int> rotateLeft1(int d, List<int> arr)
        {

            FillNewArray1(arr, arr.Count);

            for (int i = 0; i < newArray1.Count; i++)
            {
                Console.WriteLine(newArray[i]);
            }
                
            return newArray1;

        }

        private static List<int> FillNewArray1(List<int> arr, int length)
        {
            newArray1 = new List<int>();

            for (int i = 0; i < length; i++)
            {
                newArray1.Add(0);
            }

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    newArray1[length - 1] = arr[i];
                }
                else
                {
                    newArray1[i - 1] = arr[i];
                }
            }

            return newArray1;
        }


    }
}
