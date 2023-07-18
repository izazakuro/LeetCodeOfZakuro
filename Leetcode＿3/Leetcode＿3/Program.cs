using System;

namespace 最长字符串
{

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> hashTable = new Dictionary<char, int>();

            int left = 0;
            int right = s.Length - 1;
            int count = 0;
            int length = s.Length;

            while(right < length)
            {
                if (!hashTable.ContainsKey(s[right]))
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
