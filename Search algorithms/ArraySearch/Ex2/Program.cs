using System;
using System.Linq;
using System.Collections.Generic;


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] arr = { 2, 1, 7, 5, 9, 3, 6, 4, 8 };
                int n = int.Parse(Console.ReadLine());

                Search(arr, n);
            }
        }
        static void Search(int[] arr, int n)
        {
            int[] l = arr.Take(arr.Length / 2).ToArray();
            int[] r = arr.Skip(arr.Length / 2).ToArray();

            if (l.Contains(n))
            {
                if (l.Length > 1)
                {
                    Search(l, n);
                }
                else if (l[0] == n)
                {
                    Console.WriteLine($"Found number: {l[0]}");
                    return;
                }
            }
            else
            {
                if (r.Length > 1)
                {
                    Search(r, n);
                }
                else if (r[0] == n)
                {
                    Console.WriteLine($"Found number: {r[0]}");
                    return;
                }
            }

        }
    }
}
