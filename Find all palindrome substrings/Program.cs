using System;

namespace Find_all_palindrome_substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSubstrings("aaa"));
        }

        /// <summary> abc index 012
        /// we will take each char in a string and we will expand to left and right by one char at a time
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int CountSubstrings(string s)
        {
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                // when the string length is odd
                count += CountSubstringHelper(s, i, i);
                //when the string length is even
                count += CountSubstringHelper(s, i, i + 1);
            }

            return count;
        }

        static int CountSubstringHelper(string s, int left, int right)
        {
            int count = 0;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                count++; left--; right++;
            }
            return count;
        }
    }
}
