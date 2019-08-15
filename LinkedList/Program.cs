using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.PushFront(10);
            linkedList.PushFront(11);
            linkedList.PushFront(13);
            linkedList.Print();
            Console.Read();
        }
    }

}
