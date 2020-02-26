using System.Collections;

namespace RL_Generics
{
    internal static class Program
    {
        private static void Main()
        {
            // int is the type argument
            IntList list = new IntList();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (var i in list)
            {
                System.Console.Write(i + " ");
            }

            System.Console.WriteLine("\nDone");
        }
    }
}


public class IntList
{
    private class Node
    {
        private Node next;
        
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        private int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node(int t)
        {
            next = null;
            data = t;
        }
    }

    private Node head;

    // constructor
    public IntList()
    {
        head = null;
    }

    public void AddHead(int t)
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator GetEnumerator()
    {
        Node current = head;

        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}


