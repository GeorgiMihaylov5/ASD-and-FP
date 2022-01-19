using System;

namespace CombinationsWithRepetitionRecursive
{
    //  1: [0, 0]
    //  2: [0, 1]
    //  3: [0, 2]
    //  4: [0, 3]
    //  5: [1, 1]
    //  6: [1, 2]
    //  7: [1, 3]
    //  8: [2, 2]
    //  9: [2, 3]
    // 10: [3, 3]

    public static class CombinationsWithRep
    {
        private static int numberofCombos;
        private static int n;
        private static int k;
        private static int[] storageArr;
        private static char[] arr = { 'a', 'b', 'c', 'd' };

        public static void Main()
        {
            n = arr.Length;
            k = 2;
            storageArr = new int[k];

            GenCombinationsWithRep();
        }

        private static void GenCombinationsWithRep(int index = 0, int element = 0)
        {
            if (index >= storageArr.Length)
            {
                PrintCombo();
                return;
            }

            for (int i = element; i < n; i++)
            {
                storageArr[index] = i;
                GenCombinationsWithRep(index + 1, i);
            }
        }

        private static void PrintCombo()
        {
            Console.Write($"{++numberofCombos}: [ ");
            foreach (var item in storageArr)
            {
                Console.Write($"{arr[item]} ");
            }
            Console.WriteLine("]");
        }
    }
}
