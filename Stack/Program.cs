using System;
using System.Collections.Generic;

namespace Stack
{
    public class Program
    {
        //3.02-03
        /*
        
        public static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars");
            theStack.push("Jaws");
            theStack.push("Jaws 2");
            theStack.push("Titanic");
            theStack.push("Rocky");

            Console.WriteLine("========\nAbout to peek:\n");
            Console.WriteLine("'"+theStack.peek()+"' is at the top of the stack.\n");

            Console.WriteLine("========\nThe Stack contains:\n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                Console.WriteLine(movie);
            }
        }
         */

         public static void Main(string[] args)
         {
             DemoStack();
         }

         public static void DemoStack()
         {
            Stack<string> names= new Stack<string>();
            names.Push("Andrew");
            names.Push("Bobby");
            names.Push("Candy");
            names.Push("Dana");
            names.Push("Edith");

            Console.WriteLine("Default content of stack");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nPopping '{0}'",names.Pop());
            Console.WriteLine("Peek at next item to display that will be destacked {0}",names.Peek());
            Console.WriteLine("Now, after peek, popping '{0}'",names.Pop());

            Stack<string> stack2 = new Stack<string>(names.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string name in stack2)
            {
                Console.WriteLine(name);
            }

            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2,names.Count);

            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy with duplicates and nulls:");
            foreach (string name in stack3)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("\nstack2.Contains(\"Dana\") = {0}",stack2.Contains("Dana"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}",stack2.Count);

         }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string m)
        {
            if(isFull())
            {
                Console.WriteLine("This stack is full");
            } 
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("This stack is empty");
                return "--";
            }
            else
            {
                int old_top = top;
                top --;
                return stackArray[old_top];
            }
        }

        public string peek()
        {
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
        public bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
