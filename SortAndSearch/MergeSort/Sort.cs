using System;

namespace MergeSort
{
	public class Sort
	{
		//constant for array size
		const int MAX_VALUE = 1000;

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
		public static int[] MergeSort()
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
			SortArray(arr, 0, arr.Length - 1);
			return arr;
		}
	}
}
