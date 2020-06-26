using System;
using System.Text.RegularExpressions;

namespace LongestString
{
    class Program
    {
        public string LongestWord(string sen)
        {
            int len = 0;
            string[] strArray = sen.Split();
            var regexItem = new Regex("^[A-Z]*[a-z]*$");
            for (int i = 0; i < strArray.Length; i++)
            {
                if (regexItem.IsMatch(strArray[i]))
                {
                    if (strArray[i].Length > len)
                    {
                        len = strArray[i].Length;
                        sen = strArray[i];
                    }
                }                 

            }

            return sen;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.LongestWord("Argument goes here"));
        }
    }
}
