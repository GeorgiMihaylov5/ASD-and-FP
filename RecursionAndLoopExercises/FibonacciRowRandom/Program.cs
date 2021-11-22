using System;
using System.Linq;

namespace FibonacciRowRandom
{
    class Program
    {
        const int MAX_VALUE = 10;
        static long result = 1;
        static void Main(string[] args)
        {
            int[] arr = new int[MAX_VALUE];
            long[] arr1 = new long[MAX_VALUE];
            Random rnd = new Random();


            while (arr.Contains(0))
            {
                int rndInt = rnd.Next(0, MAX_VALUE);
                if (arr[rndInt] == 0)
                {
                    int num = Loop(rndInt);
                    arr[rndInt] = num;
                    Recursion(1, 0, rndInt + 1);
                    arr1[rndInt] = result;
                    result = 1;
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr1));
        }
        static void FillArraay(int[] arr)
        {
            int lastNum = 0;
            int penultimateNum = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = lastNum;
                lastNum += penultimateNum;
                penultimateNum = temp;
                arr[i] = lastNum;
            }
        }
        static int Loop(int length)
        {
            int lastNum = 1, penultimateNum = 0;
            for (int i = 0; i < length; i++)
            {
                int temp = lastNum;
                lastNum += penultimateNum;
                penultimateNum = temp;
            }
            return lastNum;
        }
        static void Recursion(long lastNum, long penultimateNum, int length, int currentLength = 1)
        {
            if (currentLength == length)
            {
                result = lastNum;
                return;
            }
            Recursion(lastNum + penultimateNum, lastNum, length, currentLength + 1);
        }
    }
}
