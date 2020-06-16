using System;
using System.Linq;

namespace TwoSum
{
    class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] complements = new int[nums.Length];
            int[] result = new int[2];
            int j = 0;
            for(int i=0;i< nums.Length; i++)
            {
                //bool b = complements.Contains(nums[i]);
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
            int[] numArray = new int[] { 1,2,4,4 };
            int target = 8;
            s.print(s.TwoSum(numArray, target));
        }
    }
}
