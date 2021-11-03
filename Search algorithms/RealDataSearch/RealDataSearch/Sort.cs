using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDataSearch
{
	public class Sort
	{

		// Merges two subarrays of []arr.
		// First subarray is arr[l..m]
		// Second subarray is arr[m+1..r]
		static void Merge(Student[] arr, int l, int m, int r)
		{
			// Find sizes of two
			// subarrays to be merged
			int n1 = m - l + 1;
			int n2 = r - m;

			// Create temp arrays
			Student[] L = new Student[n1];
			Student[] R = new Student[n2];
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
				//sort by first name
				if (L[i].FirstName.CompareTo(R[j].FirstName) < 0)
				{
					arr[k] = L[i];
					i++;
				}
				//sort by last name if first names are equal
				else if (L[i].FirstName.CompareTo(R[j].FirstName) == 0 && L[i].LastName.CompareTo(R[j].LastName) < 0)
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
		static void SortMethod(Student[] arr, int l, int arrLenght)
		{
			if (l < arrLenght)
			{
				// Find the middle
				// point
				int m = l + (arrLenght - l) / 2;

				// Sort first and
				// second halves
				SortMethod(arr, l, m);
				SortMethod(arr, m + 1, arrLenght);

				// Merge the sorted halves
				Merge(arr, l, m, arrLenght);
			}
		}

		// Driver code
		public static List<Student> SortArray(Student[] arr)
		{
			SortMethod(arr, 0, arr.Length - 1);
			return arr.ToList();
		}
	}
}
