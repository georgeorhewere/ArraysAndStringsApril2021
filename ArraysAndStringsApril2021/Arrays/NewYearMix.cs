using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsApril2021
{
    public class NewYearMix
    {

        // Complete the minimumBribes function below.
        //Print minimum number of forward switches in the array
        // Print 'Too Chaotic' for any switch that is more than 2
        public static void minimumBribes(int[] q)
        {
            //q.ToList().ForEach(Console.WriteLine);
            // Console.WriteLine("Manage Array");
            int size = q.Length;
            int minimumBribes = 0;
            bool isChaotic = false;
            for (int x = 0; x < size; x++)
            {
                int positionDifference = q[x] - (x + 1);
                //   Console.WriteLine($"Difference: { positionDifference }");
                if (positionDifference > 2)
                {
                    isChaotic = true;
                    break;
                }
                else
                {
                    if (positionDifference >= 0 && positionDifference <= 2)
                    {
                        minimumBribes += positionDifference;
                    }
                    else
                    {
                        Console.WriteLine($"Consider if { positionDifference } position difference was an initial bribe");
                    }
                }
            }

            if (isChaotic)
                Console.WriteLine("Too Chaotic");
            else
                Console.WriteLine($"Minimum Bribes { minimumBribes }");

        }

        public static void minimumBribes2(int[] q)
        {
            int minimumBribes = 0;
            int size = q.Length;
            bool isChaotic = false;
            for(int c = 0; c < size - 1; c++)
            {
                var count = q.Skip(c + 1).Where(d => q[c] > d).Count();                
                if(count > 2)
                {
                    isChaotic = true;                    
                    break;
                }
                else                
                  minimumBribes += count;
            }
            if(isChaotic)
                Console.WriteLine($"Too chaotic");
            else
                Console.WriteLine($"Minimum Bribes {minimumBribes}");
        }

        public static void minimumBribes3(int[] q)
        {
            int minimumBribes = 0;
            int size = q.Length;
            bool isChaotic = false;
            for (int c = 0; c < size - 1; c++)
            {
                int count = 0;
                for(int d = c + 1; d < size; d++)
                {
                    if (q[d] < q[c])
                        count++;
                    if (count > 2)
                        break;
                }

                if (count > 2)
                {
                    isChaotic = true;
                    break;
                }
                else
                    minimumBribes += count;
            }

            if (isChaotic)
                Console.WriteLine($"Too chaotic");
            else
                Console.WriteLine($"Minimum Bribes {minimumBribes}");
        }



        //write quick sort to 
        public static void minimumBribesReverseSort(int[] q)
        {
            int lower = 0;
            int upper = q.Length - 1;

            quickSortUtil(q, lower, upper);
            q.ToList().ForEach(c => { Console.Write($" {c}");  });
            Console.WriteLine();
            //Console.WriteLine($"Bribes {res}");
        }

        private static void quickSortUtil(int [] d, int lower, int upper)
        {
            if (lower >= upper)
                return;

            int swaps = 0;
            int mid = lower + (upper-lower)/2;
            int pivot = d[mid];
            Console.WriteLine($"mid { mid } ");
            // move items less than pivot to right and greater than to the left
            int start = lower;
            int stop = upper;
            while(lower < upper)
            {
                while (d[lower] < pivot)
                    lower++;

                while (d[upper] > pivot)
                    upper--;
                if (lower < upper)
                {
                    swap(d, lower, upper);
                    swaps++;
                }
            }

            if (pivot < d[upper]) {
                Console.WriteLine($"swap pivot { pivot }");
                swap(d, mid, lower);
                swaps++;
            }

            quickSortUtil(d, start, upper - 1); // left
           
            quickSortUtil(d, upper + 1, stop); // right

            Console.WriteLine($"Swaps { swaps }");
        }


        private static void swap(int[] d, int lower, int upper)
        {
            int temp = d[lower];
            d[lower] = d[upper];
            d[upper] = temp;            
        }
    }
}
