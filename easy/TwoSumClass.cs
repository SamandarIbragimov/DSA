using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leetcode.easy
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            var dict = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if(dict.ContainsKey(diff))
                {
                    return new int[]{dict[diff],i};
                }
                dict[nums[i]] = i;
            }
            return new int[0];
        }
    }
}