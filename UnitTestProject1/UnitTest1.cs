using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListProgram;
namespace UnitTestProject1
{
    [TestClass]
    public class TestLinkedListOperation
    {
        [TestMethod]
        public void Test_PopFront()
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.PushFront(10);
            linkedList.PushFront(11);
            linkedList.PushFront(13);
            Assert.AreEqual(linkedList.PopFront(), 13);            
        }

        [TestMethod]
        public void Test_PushBack()
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.PushBack(10);
            linkedList.PushBack(11);
            linkedList.PushBack(13);
            Assert.AreEqual(linkedList.PopFront(), 10);
        }

        [TestMethod]
        public void Test_popBack()
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.PushFront(10);
            linkedList.PushFront(11);
            linkedList.PushFront(13);
            Assert.AreEqual(linkedList.PopBack(), 10);
        }

        [TestMethod]
        public void Test_Swap()
        {
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.PushBack(10);
            linkedList.PushBack(11);

            linkedList.PushBack(12);
            linkedList.PushBack(13);
            linkedList.PushBack(14);
            linkedList.PushBack(15);
            linkedList.PushBack(16);
            linkedList.PushBack(17);
            linkedList.Swap(12, 15);
            Assert.AreEqual(linkedList.PopFront(), 10);
            Assert.AreEqual(linkedList.PopFront(), 11);
            Assert.AreEqual(linkedList.PopFront(), 15);
            Assert.AreEqual(linkedList.PopFront(), 13);
            Assert.AreEqual(linkedList.PopFront(), 14);
            Assert.AreEqual(linkedList.PopFront(), 12);
            Assert.AreEqual(linkedList.PopFront(), 16);
            Assert.AreEqual(linkedList.PopFront(), 17);
            
        }

    }
}
