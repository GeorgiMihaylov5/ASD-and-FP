using System;

namespace Loop
{
    public class BinarySearchLoop
    {
        public static void Search(int[] arr, int n, int min, int max)
        {
            while (max >= min)
            {
                //Закръглям до горното най-голямо число, защото иначе ми дава грешка
                //int mid = (int)Math.Ceiling(min + (max - min) / 2d);
                int mid = min + (max - min) / 2;

                if (arr[mid] == n)
                {
                    Console.WriteLine($"Found number: {arr[mid]} in {mid} position");
                    return;
                }

                if (n < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine("Eror 404! Not Found");
        }
    }
}
