using System;
using System.Linq;
using System.Collections.Generic;


namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] arr = { 1, 2, 3, 4 };
                int n = int.Parse(Console.ReadLine());

                Search(arr, n, 0, arr.Length);
            }
        }
        static void Search(int[] arr, int n, int min, int max)
        {
            //Закръглям до горното най-голямо число, защото иначе ми дава грешка
            int mid = (int)Math.Ceiling(min + (max - min) / 2d);

            if (n <= mid)
            {
                max = mid;
            }
            else
            {
                min = mid;
            }

            if (mid != n)
            {
                //Search(arr, n, min, max);
                if (!(min == max && min == mid && max == mid))
                {
                    Search(arr, n, min, max);
                }
                else
                {
                    Console.WriteLine("Eror 404! Not Found");
                }

            }
            else
            {
                Console.WriteLine($"Found number: {mid}");
                return;
            }
        }
    }
}
