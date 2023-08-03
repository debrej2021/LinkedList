// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

namespace LinkedList
{
    //Console.WriteLine("Hello, World!");
     class GFG
    {
      public static Node head = null;
       public static Node second = null;
       public static Node third = null;
        //static void Main()
        //{
        //    printList();
        //}

        // Structure of Node
        public class Node
        {
            public int data;
            public Node? next;
            public Node()
            {

            }

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }


            // Function to print the content of
            // linked list starting from the
            // given node
            static void printList(Node n)
        {

            // Iterate till n reaches null
            while (n != null)
            {

                // Print the data
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        // Driver Code
        public static void Main(String[] args)
        {
            

            // Allocate 3 nodes in
            // the heap
            head = new Node();
            second = new Node();
            third = new Node();

            // Assign data in first
            // node
            head.data = 1;

            // Link first node with
            // second
            head.next = second;

            // Assign data to second
            // node
            second.data = 2;
            second.next = third;

            // Assign data to third
            // node
            third.data = 3;
            third.next = null;

            Console.Read();
            Push(4);
            printList(head);
        }

        public static void Push(int data)
        {
            Node new_node = new Node(data);
            new_node.next = head;
            head = new_node;
        }
    }
}

