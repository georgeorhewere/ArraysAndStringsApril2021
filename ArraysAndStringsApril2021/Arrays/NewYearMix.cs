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
            for(int x = 0; x < size; x++)
            {
                int positionDifference = q[x] - (x + 1);
             //   Console.WriteLine($"Difference: { positionDifference }");
                if(positionDifference > 2)
                {
                    isChaotic = true;                    
                    break;
                }
                else
                {
                    if(positionDifference >= 0 && positionDifference <= 2)
                    {
                        minimumBribes += positionDifference;
                    }
                    else
                    {
                        Console.WriteLine($"Consider if { positionDifference } position difference was an initial bribe");
                    }
                }
            }

            if(isChaotic)
                Console.WriteLine("Too Chaotic");
            else
                Console.WriteLine($"Minimum Bribes { minimumBribes }");



        }
    }
}
