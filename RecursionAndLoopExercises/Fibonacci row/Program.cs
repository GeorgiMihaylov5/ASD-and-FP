using System;
using System.Diagnostics;

namespace Fibonacci_row
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            int n = int.Parse(Console.ReadLine());

            //Console.Write("Recursion: ");
            //stopwatch.Start();
            //Recursion(1, 0, n);
            //stopwatch.Stop();
            //Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
            //stopwatch.Reset();

            //Console.WriteLine(new string('-', 15));

            //Console.Write("Loop: ");
            //stopwatch.Start();
            //Loop(1, 0, n);
            //stopwatch.Stop();
            //Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
            
            Console.Write("Loop: ");
            stopwatch1.Start();
            Loop(1, 0, n);
            stopwatch1.Stop();
            Console.WriteLine($"Ticks: {stopwatch1.ElapsedTicks}");

            Console.WriteLine(new string('-', 15));

            Console.Write("Recursion: ");
            stopwatch2.Start();
            Recursion(1, 0, n);
            stopwatch2.Stop();
            Console.WriteLine($"Ticks: {stopwatch2.ElapsedTicks}");
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
        static void Loop(long lastNum, long penultimateNum, int length)
        {
            for (int i = 1; i < length; i++)
            {
                long temp = lastNum;
                lastNum += penultimateNum;
                penultimateNum = temp;
            }
            Console.WriteLine(lastNum);
        }
    }
}
