using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ArraysAndStringsApril2021
{

    // return the number of substrings in a string that meet the following conditions
    /// <summary>
    /// a. all the characters are the same 
    /// b. the string is separated in the middle by a single character
    /// </summary>
    public class SpecialStrings
    {
        public static long substrCount(int n, string s)
        {
            var timer = new Stopwatch();
            List<string> subStringPerms = new List<string>();
            timer.Start();
            int numOfSpecialSubstrings = 0;
            for (int x = 0; x < n; x++)
            {
                //add current char
                //subStringPerms.Add(s[x].ToString());
                //get permutations
                int count = x + 1;
                for (int r = 0; r < x + 1; r++)
                {
                    string substring = s.Substring(r, count);
                    if (substring.All(f => f == substring.First()))
                    {            
                        numOfSpecialSubstrings++;
                    }
                    else if (substring.Length > 2)
                    {
                        int midpoint = substring.Length / 2;
                        //Console.WriteLine($"midpoint of { d } is { midpoint } value- {d[midpoint]} left {d.Substring(0, midpoint)} right - {d.Substring(midpoint + 1)} ");
                        if (substring.Substring(0, midpoint).Equals(substring.Substring(midpoint + 1)))
                        {
                            numOfSpecialSubstrings++;
                        }
                    }                    
                    count--;
                }

            }


            timer.Stop();
            Console.WriteLine($"number of permutations - {subStringPerms.Count()} time taken - { timer.ElapsedMilliseconds }");

            return numOfSpecialSubstrings;
        }
    }
}
