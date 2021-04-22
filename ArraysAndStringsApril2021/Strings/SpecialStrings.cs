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

            if(s.All(c=> c == s.First()))
            {
                numOfSpecialSubstrings = Enumerable.Range(1, n).Sum();                
            }
            else
            {
                for (int x = 0; x < n; x++)
                {
                    int count = x + 1;
                    string substring = s.Substring(0, count);                    
                    //get permutations
                    if (substring.All(f => f == substring.First()))
                    {
                        int wordLength = substring.Length;
                        numOfSpecialSubstrings = Enumerable.Range(1, wordLength).Sum();
                    }
                    else
                    {
                       
                        for (int r = 0; r < x + 1; r++)
                        {
                            string wordPerm = s.Substring(r, count);
                            if (wordPerm.Length % 2 == 1)
                            {
                                int midpoint = wordPerm.Length / 2;
                                if (wordPerm.Substring(0, midpoint).Equals(wordPerm.Substring(midpoint + 1)))
                                {
                                    numOfSpecialSubstrings++;
                                }
                            }
                            count--;
                        }
                    }
                }

            }




            


            timer.Stop();
            Console.WriteLine($"number of permutations - {subStringPerms.Count()} time taken - { timer.ElapsedMilliseconds }");

            return numOfSpecialSubstrings;
        }
    }
}
