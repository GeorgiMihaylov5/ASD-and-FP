using System;
using System.Diagnostics;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        //constant for array size
        const int MAX_VALUE = 100;
        static void Sort(int[] arr)
        {
            int n = arr.Length;


            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;


                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }


        // Prints the array
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver code
        static void Main()
        {
            Random rnd = new Random();
            int[] arr = new int[MAX_VALUE];

            int index = 0;
            int end = int.MaxValue;
            while (end != 0)
            {
                bool isTrue = false;

                for (int j = 0; j < MAX_VALUE; j++)
                {
                    int rndInt = rnd.Next(1, MAX_VALUE * 10);
                    if (arr[j] == 0)
                    {
                        for (int k = 0; k < MAX_VALUE; k++)
                        {
                            if (arr[k] != rndInt)
                            {
                                isTrue = true;
                                index = j;
                                continue;
                            }
                            else
                            {
                                isTrue = false;
                                break;
                            }
                        }

                    }
                    if (isTrue)
                    {
                        arr[index] = rndInt;
                        isTrue = false;
                    }
                }
                int zeroNumsCount = 0;
                foreach (var item in arr)
                {
                    if (item == 0)
                    {
                        zeroNumsCount++;
                    }
                }

                end = zeroNumsCount;
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Sort(arr);
            stopWatch.Stop();
            Console.WriteLine("Sorted array");
            PrintArray(arr);

            Console.WriteLine($"Time: {stopWatch.ElapsedTicks} ticks");
        }
    }
}
