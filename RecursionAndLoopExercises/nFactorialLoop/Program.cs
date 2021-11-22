using System;
using System.Diagnostics;

namespace nFactorialLoop
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

                Console.Write("Loop: ");
                stopwatch.Start();
                Loop(n);
                stopwatch.Stop();
                Console.WriteLine(result);
                Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
            }
        }
        static void Loop(int n)
        {
            for (int i = n; i > 0; i--)
            {
                result *= n;
                n--;
            }
        }
    }
}
