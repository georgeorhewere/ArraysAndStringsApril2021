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
        private int swapCount;

        public QuickSortMidPivot(int [] numberList)
        {
            quickSortArray = numberList;
            swapCount = 0;
        }

        public void sort()
        {
            Console.WriteLine($"Initial array state");
            printArrayForTest(quickSortArray);
            quickSortUtility(quickSortArray, 0, quickSortArray.Length - 1);
            Console.WriteLine($"");
            Console.WriteLine($"Final array state- number of swaps {swapCount} ");
            printArrayForTest(quickSortArray);
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
            // Console.WriteLine($"Mid Point {mid} Pivot {pivot}");
            
            
            while(lower < upper)
            {
                // copy items less than the pivot to the left
                // copy items greater than the pivot to the right
                while (arr[lower].CompareTo(pivot) < 0)
                {
                    lower++;
                }

                while (arr[upper].CompareTo(pivot) > 0 )
                {
                    upper--;
                }

                if (lower < upper)
                {
                    swap(arr, upper, lower);
                    swapCount++;
                }

            }
            //Console.WriteLine($"After ordering by the pivot");
            //printArrayForTest(arr);

            //Console.WriteLine($"After Swap with upper : {upper} start :{ start}");
            if (arr[upper] < arr[start])
            {
                swap(arr, upper, start); //upper is the pivot position
                swapCount++;
            }
           
            //printArrayForTest(arr);

            // call recursive function for left and right arrays
            quickSortUtility(arr, start, upper - 1); //pivot -1 is the upper for left sub array.
            quickSortUtility(arr, upper + 1, stop); // pivot + 1 is the lower for right sub array.

        }

        private void swap(int[] arr, int first, int second)
        {

            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }


        private void printArrayForTest(int [] arr)
        {
            arr.ToList().ForEach(x => { Console.Write($" {x}"); });
            Console.WriteLine($"");
        }

    }
}
