using System;

namespace MergeSortedArray
{
    public class MergeSorted
    {
        public int[] merge(int[] array1, int[] array2)
        {
            int totalLength = array1.Length + array2.Length;
            int[] merged = new int[totalLength];
            int j = 0, k = 0;
            int length1 = array1.Length, length2 = array2.Length;
            Console.WriteLine("Copied");
            print(array1);
            Console.WriteLine("====");
            //Checking the inputs
            if (length1 == 0)
            {
                return array2;
            }
            if (length2 == 0)
            {
                return array1;
            }

            for (int i = 0; i < totalLength; i++)
            {
                  if (k != length2 && j != length1) 
                  {
                    if (array1[j] < array2[k])
                    {
                        merged[i] = array1[j];
                        j++;
                    }
                    else if (array1[j] > array2[k])
                    {
                        merged[i] = array2[k];
                        k++;
                    }
                    else
                    {
                        merged[i] = array1[j];
                        i += 1;
                        merged[i] = array1[j];
                        j++;
                        k++;
                    }
                  }
                else
                {
                    //merged[i] = (j == length1 ? array2[k] : array1[j]);
                    if(j == length1 && i!=totalLength)
                    {
                        merged[i] = array2[k];
                        k++;
                    }
                    else
                    {
                        merged[i] = array1[j];
                        j++;
                    }
                }
        
        }
            return merged;
        }



        

        public void print(int[] merged)
        {
            for (int i = 0; i < merged.Length; i++)
            {
                Console.WriteLine(merged[i]);
            }
        }
        public static void Main(string[] args)
        {
            MergeSorted ms = new MergeSorted();
            int[] a1 = new int[] {1,0};
            int[] a2 = new int[] {0};
            int[] result = ms.merge(a1, a2);
            ms.print(result);

        }
    }
}
