using System;

namespace RotateArray
{
    class Program
    {
        public void Rotate(int[] nums, int k)
        {
            int[] rotateArray = new int[nums.Length];
            int times = k, lastIndex = nums.Length-1;
            if (k >= 0 && nums.Length >= 1 && nums.Length <= 2 * Math.Pow(10, 4))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (times > 0)
                    {
                        rotateArray[times - 1] = nums[lastIndex];
                        times--;
                        lastIndex--;
                    }
                    else
                    {
                        rotateArray[i] = nums[i - k];
                    }
                }
            }
            else
                rotateArray = nums;

            for(int i = 0; i < rotateArray.Length; i++)
            {
                Console.WriteLine(rotateArray[i]);
            }
        }

        public void Rotate1(int[] nums, int k)
        {
            int[] rotateArray = new int[nums.Length];



            for (int i = 0; i < rotateArray.Length; i++)
            {
                Console.WriteLine(rotateArray[i]);
            }
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Rotate(new int[] {-1,-100,3,99}, 2);  
        }
    }
}
 