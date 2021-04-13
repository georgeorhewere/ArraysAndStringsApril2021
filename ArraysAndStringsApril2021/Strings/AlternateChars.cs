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
                StringBuilder builder = new StringBuilder(s.Length);
                // BruteForceCharCheck(s, builder);
                int index = 0;
                int skip = 0;

                while (index < s.Length)
                {
                    var DistinctChars = s.Skip(skip).TakeWhile(x =>
                    {
                        bool retVal;
                        retVal = index == 0 || (index > 0 && builder.ToString().Last() != x);
                        Console.WriteLine($"index {index} x { x } retVal {retVal} ");
                        if (retVal)
                            builder.Append(x);
                        index++;
                        skip = index;
                        return retVal;
                    }).ToList();

                    var t =  new String(DistinctChars.ToArray());
                }
                //builder = new StringBuilder(new String(DistinctChars.ToArray()));



                // get difference in length to identify minimum deletions
                minimumDeletions = s.Length - builder.Length;
            }

            Console.WriteLine($"The minimum deletions for {s} is {minimumDeletions}");
            return minimumDeletions;
        }

        private static void BruteForceCharCheck(string s, StringBuilder builder)
        {
            foreach (var c in s)
            {
                if (builder.Length == 0)
                    builder.Append(c);
                else
                {
                    // get dast char in builder
                    var lastCharInBuilder = builder.ToString().Last();
                    if (!c.Equals(lastCharInBuilder))
                        builder.Append(c);
                }
            }
        }
    }
}
