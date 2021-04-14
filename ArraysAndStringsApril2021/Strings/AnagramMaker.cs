using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsApril2021
{
    public class AnagramMaker
    {


        //return minimum deletions from both strings to make each of them an anagram
        public static int makeAnagram(string a, string b)
        {
            int firstWordLength = a.Length;
            int secondWordLength = b.Length;

            for(int x= 0; x < a.Length; x++)
            {
                if (b.Contains(a[x]))
                {
                    firstWordLength--;
                    secondWordLength--;
                }
            }

            var minDeletions = firstWordLength + secondWordLength;
            Console.WriteLine($"Minimum deletions { minDeletions } from { a} and {b} ");
            return minDeletions;
        }

    }
}
