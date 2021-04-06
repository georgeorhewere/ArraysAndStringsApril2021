using ArraysAndStringsApril2021.Sorting;
using System;

namespace ArraysAndStringsApril2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            testQuickSortMidPivot();
        }


        static void testQuickSortMidPivot()
        {
            int[] numbers = new int[] {7,1,3,2,4, 5,6 };
            QuickSortMidPivot manager = new QuickSortMidPivot(numbers);
            manager.sort();


        }
    }
}
