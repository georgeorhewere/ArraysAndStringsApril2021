using ArraysAndStringsApril2021.Sorting;
using System;

namespace ArraysAndStringsApril2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // testQuickSortMidPivot();
            int testFactorial = 15;
            int finalFactorialValue = factorial(testFactorial);
            Console.WriteLine($" Factorial {testFactorial} is { finalFactorialValue }");

        }


        static void testQuickSortMidPivot()
        {
            int[] numbers = new int[] {7,1,3,2,4, 5,6 };
            QuickSortMidPivot manager = new QuickSortMidPivot();
            manager.sort(numbers);

            //numbers = new int[] { 4,3,1,2};            
            //manager.sort(numbers);

            //numbers = new int[] { 2,3,4,1,5 };
            //manager.sort(numbers);
            

            //numbers = new int[] { 1, 3, 5, 2, 4, 6, 7 };
            //manager.sort(numbers);
            /// 3 7 6 9 1 8 10 4 2 5 result is 9
            numbers = new int[] { 3, 7, 6, 9, 1, 8, 10, 4, 2, 5 };
            manager.sort(numbers);


        }


        static int factorial(int num)
        {
            Console.WriteLine($"factorial {num}");
            //termination condition
            if(num <= 1)
            {
                return 1;
            }
            //call self and move towards termination
            return num * factorial(num - 1);
        }

    }
}
