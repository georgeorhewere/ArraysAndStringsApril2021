using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsApril2021
{
    public class AlternateChars
    {

        public static int alternatingCharacters(string s)
        {
            int minimumDeletions = 0;
            if (!s.Any())
                return minimumDeletions;

            //// check if it has 2 distinct chars
            var distinctCharGroups = s.GroupBy(d => d);
            if(distinctCharGroups.Count() <= 1)
            {
                minimumDeletions = s.Length - 1;
            }
            else
            {
                Console.WriteLine("process string");
            }

            Console.WriteLine($"The minimum deletions for {s} is {minimumDeletions}");
            return minimumDeletions;
        }
    }
}
