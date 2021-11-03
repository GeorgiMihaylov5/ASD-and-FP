using System;
using System.Diagnostics;

namespace Ex1
{
    class Program
    {
        const int MAX_VALUE = 100;
        const int NUMS_COUNT = MAX_VALUE / 10;
        static long sum = 0;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[MAX_VALUE];
            FillArray(arr);

            for (int i = 0; i < NUMS_COUNT; i++)
            {
                Search(arr);
            }
            Console.WriteLine();
            Console.WriteLine($"All ticks: {sum}");
            Console.WriteLine($"Average ticks: {sum / NUMS_COUNT}");
        }


        static void Search(int[] arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            int rndInt = rnd.Next(0, MAX_VALUE);

            stopwatch.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[rndInt])
                {
                    Console.WriteLine($"Found number: {arr[i]} in {i} position");
                    break;
                }
                if (i == arr.Length-1)
                {
                    Console.WriteLine("Eror 404! Not Found");
                }
            }
            stopwatch.Stop();
            sum += stopwatch.ElapsedTicks;
        }

        static void FillArray(int[] arr)
        {
            int index = 0;
            bool isContaninsNum = false;
            //long counter = 0;

            while (arr[arr.Length - 1] == 0)
            {
                Console.Write($"Loading...\r");
                //counter++;

                int rndInt = rnd.Next(0, MAX_VALUE * 10);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == rndInt)
                    {
                        isContaninsNum = true;
                        break;
                    }
                }
                if (!isContaninsNum)
                {
                    arr[index] = rndInt;
                    index++;
                }
                isContaninsNum = false;
            }
        }
    }
}
