using System;

namespace RotateArray
{
    class Program
    {
        //Time Complexity = O(n)
        //Space Complexity = O(n)
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
        //Time Complexity = O(n)
        //Space Complexity = O(n)
        public void Rotate1(int[] nums, int k)
        {
            int[] res = new int[nums.Length];
            int len = nums.Length;
            k = k % len;
                for (int i = 0; i < nums.Length; i++)
                {
                    int index = (i - k) >= 0 ? (i - k) : (len + i - k);
                    res[i] = nums[index];
                }
            
            nums = res;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        //Time Complexity = O(n)
        //Space Complexity = O(1)
        public void Rotate2(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            int gcd = Gcd(k, len);
            for (int i = len-gcd; i < len; i++)
            {
                int x = i,y=1;
                int temp = nums[i];
                while (y>=0)
                {
                    y = x-gcd;
                    if(y>=0)
                    nums[x] = nums[y];
                    x = y;
                }
                nums[x+gcd] = temp;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        private int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Gcd(b, a % b);
        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Rotate1(new int[] { -1, -100, 3, 99 }, 2);  
            //p.Rotate1(new int[] { 1,2,3,4,5,6,7}, 3);
        }
    }
}
 