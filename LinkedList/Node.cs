namespace LinkedListProgram
{
    public class Node
    {
        public Node Next { get; set; }
        public int Key { get; set; }
        public Node(int key)
        {
            this.Key = key;
        }

        // to set next Node
        public void SetNext(Node node)
        {
            this.Next = node;
        }
    }
}