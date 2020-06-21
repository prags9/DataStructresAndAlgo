using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();
            if (nums != null && nums.Length > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!hashSet.Add(nums[i]))
                    {
                        return true;
                    }
                }
            }            
            return false;
            
        }
        public static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.ContainsDuplicate(new int[] { 1}));

        }
    }
}
