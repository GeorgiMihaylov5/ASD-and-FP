using System;
using System.Diagnostics;

namespace FibonacciRowRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int n = int.Parse(Console.ReadLine());

            Console.Write("Recursion: ");
            stopwatch.Start();
            Recursion(1, 0, n);
            stopwatch.Stop();
            Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
        }
        static void Recursion(long lastNum, long penultimateNum, int length, int currentLength = 1)
        {
            if (currentLength == length)
            {
                Console.WriteLine(lastNum);
                return;
            }
            Recursion(lastNum + penultimateNum, lastNum, length, currentLength + 1);
        }
    }
}
