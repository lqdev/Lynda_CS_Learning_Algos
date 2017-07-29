using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    public class Program
    {
        //2.03
        /*
        
        public static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            myList.insertLast(999000);
            myList.displayList();
            myList.deleteFirst();
            myList.displayList();
        }
         */

         public static void Main(string[] args)
         {
            DemoLinkedListFeatures();
         }

        public static void DemoLinkedListFeatures()
        {
            string[] words = {"the", "actor", "jumped", "over", "the", "director"};
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence);

            sentence.AddFirst("today");
            Display(sentence);

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence);

            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence);

            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence);

            sentence.RemoveFirst();
            LinkedListNode<string> current =  sentence.FindLast("the");
            Display(sentence);
            
            sentence.AddAfter(current,"old");
            sentence.AddAfter(current,"lazy");
            Display(sentence);

            current = sentence.Find("actor");
            Display(sentence);

            sentence.AddBefore(current,"quick");
            sentence.AddBefore(current,"skinny");
            Display(sentence);

            Console.ReadLine();
        }

        public static void Display(LinkedList<string> list)
        {
            LinkedListNode<string> current = list.First;
            while(current != null)
            {
                IndicateNode(current);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public static void IndicateNode(LinkedListNode<string> node)
        {
            Console.Write(" ");
            Console.Write(node.Value);
        }
    }

    

    public class SinglyLinkedList
    {
        private Node first;

        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void displayList()
        {
            Console.WriteLine("List (first -- last)");
            Node current = first;
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }

        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }

}
