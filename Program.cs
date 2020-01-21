using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node() { Value = 1 };
            var node2 = new Node() { Value = 2, Prev = node1 };
            var node3 = new Node() { Value = 3, Prev = node2 };
            node1.Next = node2;
            node2.Next = node3;

            var head = Reverse(node1);

            while (head != null)
            {
                Console.WriteLine(head.Value);
                head = head.Next;
            }
        }

        static Node Reverse(Node head)
        {
            if (head == null || head.Next == null)
                return null;

            Node temp = null;
            Node current = head;
            Node newHead = head;

            while (current != null)
            {
                if (current.Next != null && current.Next.Prev != current)
                    return null;

                temp = current.Next;
                current.Next = current.Prev;
                current.Prev = temp;
                newHead = current;
                current = current.Prev;
            }

            return newHead;
        }
    }

    class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;
    }
}
