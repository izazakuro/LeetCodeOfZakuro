using System.Collections.Generic;

namespace Leetcode5
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {

            Dictionary<char, int> hashTable = new Dictionary<char, int>();
            int length = s.Length;
            int left = 0;
            int right = length - 1;
            int element = length;
            int num = 0;
            string result = "";
            string temp = "";

            while(element > 0)
            {
                if (!hashTable.ContainsKey(s[right]) || !hashTable.ContainsKey(s[left]))
                {

                    hashTable.Add(s[right], right);



                }
               

            }

            return result;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {

            string s = Console.ReadLine();

            Solution solution = new Solution();

            string result = solution.LongestPalindrome(s);

            Console.WriteLine(result);

            return;
        }
    }

}