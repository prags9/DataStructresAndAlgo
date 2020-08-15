using System;

namespace DoublyLinkedList
{
    public class Node
    {
        public Object value { get; set; }
        public Node prev { get; set; }
        public Node next { get; set; }

        public Node(Object value) {
            this.value = value;
            this.prev = null;
            this.next = null;
        }
    }
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        int length;

        public DoublyLinkedList(Object value)
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
            this.head.prev = newNode;
            this.head = newNode;
            length++;
            
        }
        //Insering at the end.
        public void append(Object value)
        {
            Node newNode = new Node(value);
            newNode.prev = this.tail;
            this.tail.next = newNode;
            length++;

        }
        public void insert(int index, Object value)
        {
            
            Node newNode = new Node(value);
            Node n = this.traversal(index);            
            newNode.prev = n.prev;                    
            newNode.next = n;
            n.prev.next = newNode;
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
            Node n = this.traversal(index);
            n.prev.next = n.next;
            n.next.prev = n.prev;
            this.length--;
        }
        public void printDll()
        {
            Node n = this.head;
            while (n!=null)
            {
                Console.Write("-->"+n.value);
                n = n.next;
            }

            Console.WriteLine("\nThe length is :"+this.length);
        }
        public static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList(10);
            dll.prepend(5);
            dll.append(15);
            dll.prepend(1);
            dll.insert(2, 3);
            dll.insert(4, 8);
            dll.printDll();
            dll.remove(4);
            dll.printDll();
        }
    }
}
