using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MyArray
{
    public class MyArray
    {
        private int length;
        private Object[] data;
        //dynamic data = new ExpandoObject();
        private int capacity ;

        public MyArray()
        {
            this.length = 0;
            this.data = new object[5];
            this.capacity = 5;
        }

        //Access. O(1)
        public object get(int index)
        {
            return this.data[index];
        }

        //Insert. //O(1)
        public void push(object item)
        {
            if(this.length == capacity)
            //Array.Copy(data, this.data, capacity * 2);
            Array.Resize(ref this.data, capacity * 2);
            this.data[this.length] = item;
            this.length++;
        }

        //Deletion . O(n)
        public void delete(int index)
        {
            for(int i = index; i < this.length; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            Array.Resize(ref this.data, this.length - 1);
            this.length--;
        }

        //Pop. O(1)
        public void pop()
        {
            Array.Resize(ref this.data, this.length - 1);
            this.length--;
        }

        public void print()
        {
            for(int i = 0; i < this.length; i++)
            {
                Console.Write(this.data[i]+" ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            MyArray myArray = new MyArray();
            myArray.push("hello");
            myArray.push("Paa");
            myArray.push("You");
            myArray.push("are");
            myArray.push("awesome");
            myArray.push("!!");
            Console.WriteLine("Before Operation");
            Console.WriteLine("The length is "+myArray.length);
            myArray.print();
            Console.WriteLine("=============================");
            //Pop Function checking
            //myArray.pop();

            //Delete function checking
            //myArray.delete(1);

            //Get function checking
            //Console.WriteLine(myArray.get(1));

            Console.WriteLine("After Operation");
            Console.WriteLine("The length is " + myArray.length);
            Console.WriteLine("My Array is::");
            myArray.print();

            Console.ReadLine();
        }
    }
}
