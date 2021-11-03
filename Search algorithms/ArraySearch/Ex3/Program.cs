using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using MergeSort;

namespace Ex3
{
    class Program
    {
        const int MAX_VALUE = 10;
        const int SEARCHED_NUMS = 1;
        static void Main(string[] args)
        {
            int[] arr = Sort.MergeSort(MAX_VALUE);
            Random rnd = new Random();

            Stopwatch stopwatch = new Stopwatch();
            int[] arrSearch = new int[SEARCHED_NUMS];
            for (int i = 0; i < arrSearch.Length; i++)
            {
                arrSearch[i] = rnd.Next(0, arr.Length);
            }
            for (int i = 0; i < SEARCHED_NUMS; i++)
            {
                stopwatch.Start();
                Search(arr, arrSearch[i], 0, arr.Length - 1);
                stopwatch.Stop();
            }
            Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
            Console.WriteLine($"Average ticks: {stopwatch.ElapsedTicks / SEARCHED_NUMS}");
        }
        static void Search(int[] arr, int n, int min, int max)
        {
            //Закръглям до горното най-голямо число, защото иначе ми дава грешка
            //int mid = (int)Math.Ceiling(min + (max - min) / 2d);
            int mid = min + (max - min) / 2;

            if (mid == n)
            {
                Console.WriteLine($"Found number: {arr[mid]}");
                return;
            }

            if (n < mid)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }

            if (max >= min)
            {
                Search(arr, n, min, max);
            }
            else
            {
                Console.WriteLine("Eror 404! Not Found");
                return;
            }
        }
    }
}
