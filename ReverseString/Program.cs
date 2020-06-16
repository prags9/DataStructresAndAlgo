using System;

namespace ReverseString
{
    class Program
    {       

        public string reverse(string str)
        {
            if(str==null || str.Length==1 || !typeof(string).FullName.Equals("System.String"))
            {
                return "Bad Input";
            }
            int totalItems = str.Length - 1;
            string resultStr = "";//= new string[str.Length];
            for (int i = totalItems; i >= 0; i--)
            {
                resultStr = resultStr + str[i];
            }
            return resultStr;
        }

        public string reverse2(string str)
        { 
            char[] tempStr = str.ToCharArray();
            Array.Reverse(tempStr); 
            return String.Concat(tempStr);            
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            string s = "This is csharp";        

            Console.WriteLine(p.reverse2(s));
            
        }
    }
}
