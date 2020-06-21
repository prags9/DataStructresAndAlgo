using System;
using System.Linq;

namespace MoveZeros
{
    class Solutions
    {
        public void MoveZeroes(int[] nums)
        {
            int firstZero = -1;
            for(int i= 0; i < nums.Length; i++)
            {
                if (nums.Contains(0))
                {
                    firstZero = Array.IndexOf(nums, 0);
                }
                if(nums[i] != 0 && firstZero>=0 && i>firstZero)
                {
                    int temp = nums[i];
                    nums[i] = nums[firstZero];
                    nums[firstZero] = temp;
                }
                
            }
            //Print the array
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public static void Main(string[] args)
        {
            Solutions s = new Solutions();
            s.MoveZeroes(new int[] {4, 2, 4, 0, 0, 3, 0, 5, 1, 0});
        }
    }
}
