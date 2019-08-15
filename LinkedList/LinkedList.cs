using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    /// <summary>
    ///  class that represent linked list.
    /// </summary>
   public class SingleLinkedList
    {
        private Node Head { get; set; }
        private Node Tail { get; set; }
        public SingleLinkedList()
        {

        }

        // to insert at the front of the linked list   O(1)
        public void PushFront(int key)
        {
            Node node = new Node(key);

            // set head next to the new node
            node.SetNext(Head);

            // set new node as head
            this.Head = node;

            if (Tail == null)
            {
                this.Tail = node;
            }
        }

        //O(1)
        public int PopFront()
        {
            // base case 
            if (Head == null)
            {
                throw new Exception("there are not data");
            }

            //saev old head
            Node oldHead = Head;
            // set head.next as new head
            Head = Head.Next;
            // set tail null in case head == null
            if (Head == null)
            {
                Tail = null;
            }

            return oldHead.Key;
        }

        // to insert at the back of the linked list       //O(1)
        public void PushBack(int key)
        {
            Node node = new Node(key);

            if (Tail == null)
            {
                Tail = node;
                Head = node;
            }
            else
            {
                Tail.SetNext(node);
                Tail = node;
            }                    
        }


        // to pop last element from linked list .
        //O(N)
        public int PopBack()
        {
            Node oldTail = Tail;
            if (Tail == null)
            {
                throw new Exception("there are no data");
            }
            Node current = Head;
            // loop till u find the one before tail
            while (current.Next != Tail)
            {
                current = current.Next;
            }

            //set currne  to be new tail
            current.Next = null;
            Tail = current;

            // return the result
            return oldTail.Key;    
        }

        public void Swap(int x, int y)
        {
            Node preX = null;
            Node nodeX = null;
            Node nextX = null;
            ///

            Node preY = null;
            Node nodeY = null;
            Node nextY = null;
            Node current = Head;
            // loop till u find last one
            while (current.Next != null)
            {
                // get preX  , NodeX
                if (current.Next.Key == x)
                {
                    preX = current;
                    nodeX = current.Next;
                    nextX = current.Next.Next;
                }
                // get preY,NodeY
                if (current.Next.Key == y)
                {
                    preY = current;
                    nodeY= current.Next;
                    nextY = current.Next.Next;
                }
                current = current.Next;
            }
            nodeX.Next = nextY;
            nodeY.Next = nextX;


            preX.Next = nodeY;
            preY.Next = nodeX;

        }
        

        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Key.ToString() + " ");
                current = current.Next;
            }
        }
    }
}
