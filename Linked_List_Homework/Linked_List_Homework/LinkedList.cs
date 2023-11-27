using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
             Node newNode = new Node(val);

            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
        if (First == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (First.Data == key)
            {
                First = First.Next;
                return;
            }

            Node current = First;
            Node previous = null;

            while (current != null && current.Data != key)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Key not found in the list");
                return;
            }

            previous.Next = current.Next;
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
         if (First == null)
            {
                First = other_list.First;
                return;
            }

            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
        Node previous = null;
            Node current = First;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            First = previous;
        }
    }
}
