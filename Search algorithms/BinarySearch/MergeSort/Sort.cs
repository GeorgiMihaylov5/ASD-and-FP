using System;

namespace MergeSort
{
	public class Sort
	{
		//constant for array size
		//const int MAX_VALUE = 100;

		// Merges two subarrays of []arr.
		// First subarray is arr[l..m]
		// Second subarray is arr[m+1..r]
		static void Merge(int[] arr, int l, int m, int r)
		{
			// Find sizes of two
			// subarrays to be merged
			int n1 = m - l + 1;
			int n2 = r - m;

			// Create temp arrays
			int[] L = new int[n1];
			int[] R = new int[n2];
			int i, j;

			// Copy data to temp arrays
			for (i = 0; i < n1; ++i)
				L[i] = arr[l + i];
			for (j = 0; j < n2; ++j)
				R[j] = arr[m + 1 + j];

			// Merge the temp arrays

			// Initial indexes of first
			// and second subarrays
			i = 0;
			j = 0;

			// Initial index of merged
			// subarray array
			int k = l;
			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					arr[k] = L[i];
					i++;
				}
				else
				{
					arr[k] = R[j];
					j++;
				}
				k++;
			}

			// Copy remaining elements
			// of L[] if any
			while (i < n1)
			{
				arr[k] = L[i];
				i++;
				k++;
			}

			// Copy remaining elements
			// of R[] if any
			while (j < n2)
			{
				arr[k] = R[j];
				j++;
				k++;
			}
		}

		// Main function that
		// sorts arr[l..r] using
		// merge()
		static void SortArray(int[] arr, int l, int arrLenght)
		{
			if (l < arrLenght)
			{
				// Find the middle
				// point
				int m = l + (arrLenght - l) / 2;

				// Sort first and
				// second halves
				SortArray(arr, l, m);
				SortArray(arr, m + 1, arrLenght);

				// Merge the sorted halves
				Merge(arr, l, m, arrLenght);
			}
		}
		public static int[] MergeSort(int MAX_VALUE)
		{
			Random rnd = new Random();
			int[] arr = new int[MAX_VALUE];
			int index = 0;
			bool isContaninsNum = false;
			//long counter = 0;

            while (arr[arr.Length-1] == 0)
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
			SortArray(arr, 0, arr.Length - 1);
            //Console.WriteLine(string.Join(" ", arr));

            return arr;
		}
	}
}
