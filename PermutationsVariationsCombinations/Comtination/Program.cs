using System;
using System.Collections.Generic;

namespace Comtination
{
    public static class GenerateCombinationsIteratively
    {
        private static char[] arr = { 'a', 'b', 'c', 'd' };
        static void Main()
        {
            var n = arr.Length;

            Console.Write("k = ");
            var k = int.Parse(Console.ReadLine());

            foreach (var combo in Combinations(k, n))
            {
                foreach (var item in combo)
                {
                    Console.Write($"{arr[item - 1]} ");
                }
                Console.WriteLine();
            }
        }

        private static IEnumerable<int[]> Combinations(int k, int n)
        {
            var result = new int[k];
            var stack = new Stack<int>();
            stack.Push(1);

            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var value = stack.Pop();

                while (value <= n)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index == k)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }
    }
}
