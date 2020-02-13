using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
    public class LargestPalindromeProduct
    {
        public int Challenge4()
        {
            int n = 0;
            
            for (int i = 900; i <= 999; i++)
            {
                for (int j = 900; j <= 999; j++)
                {
                    int PotentialCandidates = i * j;

                    if (PotentialCandidates > n) 
                    {
                        string s = PotentialCandidates.ToString();
                        char[] arr = s.ToCharArray();
                        Array.Reverse(arr);
                        string x = new string(arr);
                        long.Parse(x);

                        if (s == x)
                        {
                            n = i * j;
                        }
                    }
                }
            }
            return n;
        }
    }
}
