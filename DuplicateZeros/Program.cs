using System;
using System.Linq;

namespace DuplicateZeros
{
    class Program
    {
        public void DuplicateZeros(int[] arr)
        {
            /*if (arr.Contains(0))
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 0 && i != arr.Length-1)
                    {
                        i++;
                        for (int j = arr.Length-1; j >i; j--)
                        {                          
                            arr[j] = arr[j-1];
                        }                        
                        arr[i] = 0;
                    }
                }
            }*/
            int[] temp = (int[])arr.Clone();
            int j = 0;
            for (int i = 0; j < arr.Length && i < temp.Length; i++)
            {
                arr[j++] = temp[i];
                if (0 == temp[i] && j < arr.Length)
                {
                    arr[j++] = 0;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            //1, 0, 2, 3, 0, 4, 5, 0
            p.DuplicateZeros(new int[] { 1,2,3,0,1 });
        }
    }
}
