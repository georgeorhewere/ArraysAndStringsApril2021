using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsApril2021.Sorting
{
    public class QuickSortMidPivot
    {
        private int[] quickSortArray;

        public QuickSortMidPivot(int [] numberList)
        {
            quickSortArray = numberList;
        }

        public void sort()
        {            
            quickSortUtility(quickSortArray, 0, quickSortArray.Length - 1);
        }


        private void quickSortUtility(int[] arr, int lower, int upper)
        {
            // condition to stop the recursion
            if (upper <= lower)
            {
                return;
            }

            // select a pivot at the middle of the array
            int mid = lower + (upper - lower) / 2; // To avoid the overflow
            int pivot = arr[mid];
            int start = lower;
            int stop = upper;

            Console.WriteLine($"Mid Point {mid} Pivot {pivot}");


        }

    }
}
