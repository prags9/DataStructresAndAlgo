using System;
using System.Linq;

namespace MaximumSubarray
{
    class Solutions
    {
        public int MaxSubArray(int[] nums)
        {
            int max_sum = nums[0], curr_max=nums[0];
            for(int i=1; i< nums.Length; i++)
            {
                //Two options: either start new subarray or the previous one, whihcever is maximum.
                if (nums[i] < (nums[i] + curr_max))
                    curr_max = nums[i] + curr_max;
                else
                    curr_max = nums[i]; 
                if (max_sum < curr_max)
                    max_sum = curr_max;
            }

            return max_sum; 
            
        }
        public static void Main(string[] args)
        {
            Solutions s = new Solutions();
            Console.WriteLine(s.MaxSubArray(new int[] { -1,-1,0,-1 }));            
        }
    }
}
