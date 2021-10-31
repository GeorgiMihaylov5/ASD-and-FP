using System;

namespace Ex1
{
    class Program
    {
        const int MAX_VALUE = 100;
        const int SEARCHED_NUMS = 10;
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                int[] arr = new int[MAX_VALUE];

                int index = 0;
                int end = int.MaxValue;
                while (end != 0)
                {
                    bool isTrue = false;

                    for (int j = 0; j < MAX_VALUE; j++)
                    {
                        int rndInt = rnd.Next(1, MAX_VALUE * 10);
                        if (arr[j] == 0)
                        {
                            for (int k = 0; k < MAX_VALUE; k++)
                            {
                                if (arr[k] != rndInt)
                                {
                                    isTrue = true;
                                    index = j;
                                    continue;
                                }
                                else
                                {
                                    isTrue = false;
                                    break;
                                }
                            }

                        }
                        if (isTrue)
                        {
                            arr[index] = rndInt;
                            isTrue = false;
                        }
                    }
                    int zeroNumsCount = 0;
                    foreach (var item in arr)
                    {
                        if (item == 0)
                        {
                            zeroNumsCount++;
                        }
                    }

                    end = zeroNumsCount;
                }

                try
                {
                    for (int j = 0; j < SEARCHED_NUMS; j++)
                    {
                        Console.Write("Enter number: ");
                        int n = int.Parse(Console.ReadLine());

                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] == arr[n])
                            {
                                Console.WriteLine($"Found number: {arr[n]}");
                                break;
                            }
                        }
                        Console.WriteLine();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }

            }
        }
    }
}
