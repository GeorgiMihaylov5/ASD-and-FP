using System;
using System.Diagnostics;

namespace nFactorialRecursion
{
    class Program
    {
        static int result = 1;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stopwatch stopwatch = new Stopwatch();

            Console.Write("Recursion: ");
            stopwatch.Start();
            Recursion(n);
            stopwatch.Stop();
            Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
        }

        static void Recursion(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(result);
                return;
            }
            result *= n;
            Recursion(n - 1);
        }
    }
}