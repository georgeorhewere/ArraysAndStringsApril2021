using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<string> subStringPerms = new List<string>();
            for(int x =0; x < n; x++)
            {
                //add current char
                //subStringPerms.Add(s[x].ToString());
                //get permutations
                int count = x + 1;
                    for(int r = 0; r < x + 1; r++)
                    {
                        string substring = s.Substring(r,count);                        
                        subStringPerms.Add(substring);             
                        count--;
                    }
                
            }

            int numOfSpecialSubstrings = 0;

            foreach (string d in subStringPerms)
            {
                Console.WriteLine(d);
                //if (d.All(f => f == d.First()))
                //{
                //    Console.WriteLine(d);
                //    numOfSpecialSubstrings++;
                //}

                //int midpoint = d.Length / 2;
                //if (d.Length > 2)
                //{
                //    Console.WriteLine($"midpoint of { d } is { midpoint } value- {d[midpoint]} left {d.Substring(0, midpoint)} right - {d.Substring(midpoint + 1)} ");
                //    if (d.Substring(0, midpoint).Equals(d.Substring(midpoint +1)))
                //    {
                //        numOfSpecialSubstrings++;
                //    }
                //}
            }
                


            return numOfSpecialSubstrings;
        }
    }
}
