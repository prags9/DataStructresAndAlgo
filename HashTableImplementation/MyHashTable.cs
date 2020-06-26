using System;
using System.Collections.Generic;

namespace HashTableImplementation
{
    class MyNode
    {
        public string key;
        public object value;

        public MyNode(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class MyHashTable
    {
        private class MyNodes : List<MyNode> { }
        private MyNodes[] data;
        public MyHashTable(int size)
        {
            this.data = new MyNodes[size];
        }

        private int _hash(string key)
        {
            int hash = 0;
            for(int i = 0; i < key.Length; i++)
            {
                hash = (hash + Convert.ToInt32(key[i]) * i) % data.Length;
            }
            return hash;
        }

        //O(1)
        public object Get(string key)
        {
            int address = _hash(key);
            MyNodes currentBucket = this.data[address];
            if (currentBucket != null)
            {
                foreach(var node in currentBucket)
                {
                    if (node.key == key)
                        return node.value;
                }
            }
            return 0;
        }

        //O(1)
        public void Set(string key, object value)
        {
            int address = _hash(key);
            if (this.data[address] == null)
            {
                this.data[address] = new MyNodes();
            }

            this.data[address].Add(new MyNode(key, value));
        }

        //This method is costly in case of hashtable, as we are looping through all the 50 addresses of hashtable.
        //This was better in arrays.
        public List<string> Keys()
        {
            List<string> list = new List<string>();
            for(int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    foreach(var v in this.data[i])
                    {
                        list.Add(v.key);
                    }
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            MyHashTable hashTable = new MyHashTable(2);
            //Console.WriteLine(hashTable._hash("grapes"));
            hashTable.Set("grapes", 10000);
            hashTable.Set("apples", 900);
            hashTable.Set("Oranges", 9);
            hashTable.Set("chiku", 6);
            //Console.WriteLine(hashTable.Get("apples"));

            List<string> result = hashTable.Keys();
            foreach(var v in result)
            Console.WriteLine(v);

            //To print the hastable
            /*for(int i = 0; i < hashTable.data.Length; i++)
            {
                if (hashTable.data[i] != null)
                {
                    foreach (var v in hashTable.data[i])
                    {
                        Console.WriteLine("[{0}: {1}]", v.key, v.value);
                    }
                }               
                
            }*/
            
        }
    }
}
