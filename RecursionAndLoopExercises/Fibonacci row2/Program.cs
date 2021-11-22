using System;
using System.Diagnostics;

namespace FibonacciRowLoop
{
    class Program
    {
        static long result = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                int n = int.Parse(Console.ReadLine());

                Console.Write("Loop: ");
                stopwatch.Start();
                Loop(1, 0, n);
                stopwatch.Stop();
                Console.WriteLine(result);
                Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
            }
        }
        static void Loop(long lastNum, long penultimateNum, int length)
        {
            for (int i = 1; i < length; i++)
            {
                long temp = lastNum;
                lastNum += penultimateNum;
                penultimateNum = temp;
            }
            result = lastNum;
        }
    }
}
