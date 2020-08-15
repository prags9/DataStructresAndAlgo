using System;

namespace LinkedList
{
    public class Node
    {
        public Object value { get; set; }
        public Node next { get; set; }

        public Node(Object value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class LinkedList
    {
        private Node head;
        private Node tail;
        int length;

        public LinkedList(Object value)
        {
            Node n = new Node(value);
            this.head = n;
            this.tail = this.head;
            length = 1;
        }

        //Inserting at the beginning
        public void prepend(Object value)
        {
            Node newNode = new Node(value);
            newNode.next = this.head;
            this.head = newNode;
            length++;

        }
        //Insering at the end.
        public void append(Object value)
        {
            Node newNode = new Node(value);
            this.tail.next = newNode;
            length++;

        }
        public void insert(int index, Object value)
        {
            
            Node newNode = new Node(value);
            Node n = this.traversal(index-1);
            Node holdingPointer = n.next;
            n.next = newNode;
            newNode.next = holdingPointer;
            this.length++;
        }
        public Node traversal(int index)
        {
            int ind = 0;
            Node n = this.head;
            Node node = null;
            while (n != null)
            {
                ind++;
                if (ind == index)
                {
                    node = n;
                    return node;

                }
                n = n.next;
            }
            return node;
        }
        public void remove(int index)
        {
            Node n = this.traversal(index-1);
            n.next = n.next.next;
            this.length--;
        }
        public void printDll()
        {
            Node n = this.head;
            while (n != null)
            {
                Console.Write("-->" + n.value);
                n = n.next;
            }

            Console.WriteLine("\nThe length is :" + this.length);
        }
        public static void Main(string[] args)
        {
            LinkedList ll = new LinkedList(10);
            ll.prepend(5);
            ll.append(15);
            ll.prepend(1);
            ll.insert(2, 3);
            ll.insert(4, 8);
            ll.printDll();
            ll.remove(4);
            ll.printDll();
        }
    }
}
