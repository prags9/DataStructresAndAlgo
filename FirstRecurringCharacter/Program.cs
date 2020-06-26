using System;
using System.Collections;

namespace FirstRecurringCharacter
{
    class Program
    {
        //O(n)  -Time complexity
        //O(n)  -Space complexity
        public int FirstRecurring(int[] arr)
        {
            if (arr.Length <= 1)
                return 0;
            int num = 0;
            Hashtable result = new Hashtable();
            for(int i = 0; i < arr.Length; i++)
            {
                if (result.ContainsValue(arr[i]))
                {
                    return arr[i];
                }
                result.Add(i, arr[i]);
            }
            return num;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.FirstRecurring(new int[] { 2 }));
        }
    }
}
