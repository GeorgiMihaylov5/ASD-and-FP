﻿using Recursion;
using MergeSort;
using System;
using Loop;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace SortAndSearch
{
    class Program
    {
        const int MAX_VALUE = 10;
        const int NUMS_COUNT = MAX_VALUE / 10;
        static long sum = 0;

        static void Main(string[] args)
        {
            int[] arr = Sort.MergeSort(MAX_VALUE);
            Console.WriteLine("Recursion search / Loop search (r/l)");
            string input = Console.ReadLine();

            for (int i = 0; i < NUMS_COUNT; i++)
            {
                RandomSearch(arr, input);
            }
            Console.WriteLine($"All ticks: {sum}");
            Console.WriteLine($"Average: {sum / NUMS_COUNT} ticks");
        }
        static void RandomSearch(int[] arr, string input)
        {
            Stopwatch watch = new Stopwatch();
            Random rnd = new Random();
            int rndInt = rnd.Next(0, arr.Length);

            if (input == "r")
            {
                watch.Start();
                BinarySearchRecursion.Search(arr, arr[rndInt], 0, arr.Length - 1);
                watch.Stop();
                sum += watch.ElapsedTicks;
            }
            else if (input == "l")
            {
                watch.Start();
                BinarySearchLoop.Search(arr, arr[rndInt], 0, arr.Length - 1);
                watch.Stop();
                sum += watch.ElapsedTicks;
            }
            Console.WriteLine($"Ticks: {watch.ElapsedTicks}");
        }
    }
}
