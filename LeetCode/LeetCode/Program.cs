using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> twosum = new Dictionary<int, int>();
            //定义哈希表twosum.
            for (int i = 0; i < nums.Length; i++)
            {//定义for循环进行遍历.
                if (twosum.ContainsKey(target - nums[i]))
                {//判断Dictionary中是否存在，不存在则存入，存在则进行return输出.
                    return new int[] { twosum[target - nums[i]], i };
                }
                else
                {
                    twosum[nums[i]] = i;
                }
            }
            return new int[] { 0, 0 };//结果为null的情况.
        }
    }

}

