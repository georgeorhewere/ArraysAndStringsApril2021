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
                //TakeWhileCharCheck(s, builder);
                WhileLoopCharCheck(s, distinctCharGroups, builder);



                // get difference in length to identify minimum deletions
                minimumDeletions = s.Length - builder.Length;
            }

            Console.WriteLine($"The minimum deletions for {s} is {minimumDeletions}");
            return minimumDeletions;
        }

        private static void WhileLoopCharCheck(string s, IEnumerable<IGrouping<char, char>> distinctCharGroups, StringBuilder builder)
        {
            var distinctChars = distinctCharGroups.Select(x => x.Key).ToArray();
            builder.Append(s.First());
            int start = 1;
            while (start < s.Length)
            {
                char check = distinctChars.Where(s => s != builder.ToString().Last()).First();
                var nextIndex = s.IndexOf(check, start);
                if (nextIndex > -1)
                {
                    builder.Append(check);
                    start = nextIndex + 1;
                }
                else
                    break;
            }
        }

        private static void TakeWhileCharCheck(string s, StringBuilder builder)
        {
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

                var t = new String(DistinctChars.ToArray());
            }
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
