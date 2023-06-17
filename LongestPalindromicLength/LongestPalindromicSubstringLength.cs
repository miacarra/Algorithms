using System;
using System.IO;
using System.Threading;
using System.Linq;

namespace LongestPalindromicSubstring
{
    internal class LongestPalindromicSubstringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            int lps=0;
            int len = 0;
            if (input == null || length < 1)
                Console.WriteLine(0);
            if (input == null || length < 1)
                Console.WriteLine(1);

            for (int i = 0; i < length; i++)                            //babad
            {
                int len1 = Expand(input, i, i);
                int len2 = Expand(input, i, i + 1);
                len = Math.Max(len1, len2);
                if (len>lps)
                    lps = len;
                
            }

            Console.WriteLine(lps);
        }
        static int Expand(string input, int left, int right)
        {
            if (input == null || left > right)
                return 0;

            while (left >= 0 && right < input.Length && input[left] == input[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

    }
}