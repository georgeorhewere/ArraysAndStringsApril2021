using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsApril2021
{
    public class PermutationStrings
    {


        public static bool IsPermutation(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            
            Dictionary<char, int> charInstanceCount = new Dictionary<char, int>();
            int count = word1.Length;
            // go through each character to compare count instances for comparison
            for(int x=0; x < count; x++)
            {
                char key = word1[x];
                if (charInstanceCount.ContainsKey(key))
                {
                    charInstanceCount[key]++;
                }
                else
                {
                    charInstanceCount[key] = 1;
                }
            }

            for(int y=0; y < count; y++)
            {
                char key = word2[y];
                if (charInstanceCount.ContainsKey(key))
                {
                    charInstanceCount[key]--;
                }
                else
                {
                    return false;
                }
            }

            foreach (var v in charInstanceCount.Values)
                if (v != 0)
                    return false;


            return true;
        }

        public static bool IsPermutation2(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            Dictionary<char, int> charInstanceCount = new Dictionary<char, int>();
            int count = word1.Length;            
            // go through each character to compare count instances for comparison
            for (int x = 0; x < count; x++)
            {
                char key = word1[x];
                char key2 = word2[x];
                if (charInstanceCount.ContainsKey(key))
                {
                    if(charInstanceCount[key] < 1)
                        charInstanceCount[key]++;
                    else
                        charInstanceCount[key]--;
                }
                else
                {
                    charInstanceCount[key] = 1;
                }

                if (charInstanceCount.ContainsKey(key2))
                {
                    charInstanceCount[key2]--;
                }
                else
                {
                    charInstanceCount[key2] = 1;
                }
            }
            

            foreach (var v in charInstanceCount.Values)
                if (v != 0)
                    return false;


            return true;
        }


    }
}
