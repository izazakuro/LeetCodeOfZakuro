using System;

namespace 中位数
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();

            int length = nums1.Length + nums2.Length;

            double result;

            for(int i = 0; i < nums1.Length; i++)
            {
                list.Add(nums1[i]);
            }

            for(int i = 0; i < nums2.Length; i++)
            {
                list.Add(nums2[i]);
            }

            list.Sort();

            if(length % 2 == 0)
            {
                result = (list[length / 2] + list[length / 2 -1])/2.0;
            }
            else
            {
                result = list[length / 2 + 1];
            }

            return result;
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { 4, 5, 6 };

            double result = solution.FindMedianSortedArrays(nums, nums2);

            Console.WriteLine(result);

            return;
        }

    }
    

}