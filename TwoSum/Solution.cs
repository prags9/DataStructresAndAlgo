using System;
using System.Linq;

namespace TwoSum
{
    class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Object[] complements = new Object[nums.Length];
            int[] result = new int[2];
            int j = 0;
            for(int i=0;i< nums.Length; i++)
            {
                if (complements.Contains(nums[i]))
                {
                    int index = Array.IndexOf(complements, nums[i]);
                    result[0] = index;
                    result[1] = i;
                    break;
                }
                else
                {
                    complements[i] = target - nums[i];
                }                   
            }

            return result;
        }

        public void print(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] numArray = new int[] { 0,4,3,0 };
            int target = 0;
            s.print(s.TwoSum(numArray, target));
        }
    }
}
