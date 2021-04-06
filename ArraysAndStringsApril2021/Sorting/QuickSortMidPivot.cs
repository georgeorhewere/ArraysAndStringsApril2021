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
            Console.WriteLine($"Initial array state");
            printArrayForTest(quickSortArray);
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
            
            
            while(lower < upper)
            {
                // copy items less than the pivot to the left
                // copy items greater than the pivot to the right
                while (arr[lower] <= pivot && lower < upper)
                {
                    lower++;
                }

                while (arr[upper] > pivot && lower <= upper)
                {
                    upper--;
                }

                if (lower < upper)
                {
                    swap(arr, upper, lower);
                }

            }
            Console.WriteLine($"After ordering by the pivot");
            printArrayForTest(arr);

            Console.WriteLine($"After Swap with upper : {upper} start :{ start}");
            swap(arr, upper, start); //upper is the pivot position
           
            printArrayForTest(arr);
            
            

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
