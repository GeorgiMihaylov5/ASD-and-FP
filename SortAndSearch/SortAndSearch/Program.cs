using Recursion;
using MergeSort;
using System;

namespace SortAndSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Sort.MergeSort();
            while (true)
            {
                Console.WriteLine(String.Join(" ", arr));
                Console.Write("The number you are looking for: ");
                int n = int.Parse(Console.ReadLine());
                BinarySearchRecursion.Search(arr, n, 0, arr.Length - 1);
                Console.WriteLine();
            }

        }
    }
}
