using System;
using System.Diagnostics;

namespace nFactorialRecursion
{
    class Program
    {
        static long result;
        static void Main(string[] args)
        {
            while (true)
            {
                result = 1;
                int n = int.Parse(Console.ReadLine());
                Stopwatch stopwatch = new Stopwatch();

                Console.Write("Recursion: ");
                stopwatch.Start();
                Recursion(n);
                stopwatch.Stop();
                Console.WriteLine(result);
                Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
            }

        }

        static void Recursion(int n)
        {
            if (n == 1)
            {
                return;
            }
            result *= n;
            Recursion(n - 1);
        }
    }
}