using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class longest_substring_without_repeating_characters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int start = 0;
            int end = 0;
            int maxLength = 0;
            HashSet<char> charSet = new HashSet<char>();
            while (end < s.Length)
            {
                if (!charSet.Contains(s[end]))
                {
                    charSet.Add(s[end]);
                    end++;
                    maxLength = Math.Max(maxLength, end - start);
                }
                else
                {
                    charSet.Remove(s[start]);
                    start++;
                }
            }
            return maxLength;
        }
        //public static void Main()
        //{
        //    Console.WriteLine(LengthOfLongestSubstring("bbbb"));
        //}
    }
}
