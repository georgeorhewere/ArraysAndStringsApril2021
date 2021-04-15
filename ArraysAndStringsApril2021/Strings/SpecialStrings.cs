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
            HashSet<string> subStringPerms = new HashSet<string>();
            for(int x =0; x < n; x++)
            {
                //add current char
                subStringPerms.Add(s[x].ToString());
                //get permutations
                if(x > 0)
                {                  
                    for(int r = 0; r < x; r++)
                    {
                        string substring = s.Substring(r,(x-r));
                        if (!subStringPerms.Contains(substring))
                        {                            
                            subStringPerms.Add(substring);
                        }
                    }
                }
            }

            int numOfSpecialSubstrings = 0;

            foreach (string d in subStringPerms)
            {
                if (d.All(f => f == d.First()))
                {
                    Console.WriteLine(d);
                    numOfSpecialSubstrings++;
                }

            }
                


            return numOfSpecialSubstrings;
        }
    }
}
