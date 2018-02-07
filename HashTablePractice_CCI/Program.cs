using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');

        Console.Write(ransomNote(m, n, magazine, ransom));
    }

    static string ransomNote(int m, int n, string[] magazine, string[] ransom)
    {
        Dictionary<string, int> myMag = new Dictionary<string, int>();
        //add items to hashset
        for (int i = 0; i < m; i++)
        {
            if (!myMag.ContainsKey(magazine[i]))
            {
                myMag.Add(magazine[i], 1);
            }
            else
            {
                myMag[magazine[i]]++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!myMag.ContainsKey(ransom[i]) || myMag[ransom[i]] == 0)
            {
                return "No";
            }
            else
            {
                myMag[ransom[i]]--;
            }
        }

        return "Yes";
    }
}
