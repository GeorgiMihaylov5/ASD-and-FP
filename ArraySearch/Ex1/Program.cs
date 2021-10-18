using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] arr = { 2, 1, 7, 5, 9, 3, 6, 4, 8 };
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == n)
                    {
                        Console.WriteLine($"Found number: {n}");
                        break;
                    }
                }
            }
        }
    }
}
