using System;

namespace 最长字符串
{

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> letter = new HashSet<char>();

            int left = 0;
            int right = s.Length - 1;
            int count = 0;
            int length = s.Length;
            int max = 0;

            while(right < length)
            {
                if (!letter.Contains(s[right]))
                {
                    letter.Add(s[right]);
                    right++;
                    count++;

                }
                else
                {
                    letter.Remove(s[left]);
                    left++;
                    count--;
                }

                max = Math.Max(max, count);
            }


            return max;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            Solution solution = new Solution();
            string s = Console.ReadLine();

            a = solution.LengthOfLongestSubstring(s);

            Console.WriteLine(a);

            return;

        }
    }

}
