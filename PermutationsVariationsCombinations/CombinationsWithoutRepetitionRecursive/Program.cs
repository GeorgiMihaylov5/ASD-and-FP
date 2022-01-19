using System;

namespace CombinationsWithoutRepetitionRecursive
{
    // 1: [0, 1]
    // 2: [0, 2]
    // 3: [0, 3]
    // 4: [1, 2]
    // 5: [1, 3]
    // 6: [2, 3]

    using System;

    public static class CombinationsNoRep
    {
        private static int numberofCombos;
        private static int n;
        private static int k;
        private static int[] storageArr;
        private static char[] arr = { 'a', 'b', 'c', 'd' };

        public static void Main()
        {
            n = arr.Length;
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            storageArr = new int[k];

            GenCombinationsNoRep();
        }

        private static void GenCombinationsNoRep(int index = 0, int element = 0)
        {
            if (index >= storageArr.Length)
            {
                PrintCombo();
                return;
            }

            for (int i = element; i < n; i++)
            {
                storageArr[index] = i;
                GenCombinationsNoRep(index + 1, i + 1);
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
            //Console.WriteLine(
            //    "{0,3}: [{1}]",
            //    ++numberofCombos,
            //    string.Join(", ", storageArr));
        }
    }
}
