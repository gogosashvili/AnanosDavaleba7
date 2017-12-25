using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int Item;
        public Node Next;

        public Node(int item)
        {
            Item = item;
        }

    }
    class Program
    {

        public static void Print(Node head)
        {
            while (head != null)
            {
                Console.Write(head.Item + "  ");
                head = head.Next;
            }
            Console.WriteLine();
        }

        public static void Remove(Node head, int k)
        {
            Node current = head;
            Node previous = head;

            for (int i = 0; i < k - 1; i++)
            {
                if (head.Next == null)
                {
                    return;
                }

                previous = current;
                current = current.Next;
            }

            previous.Next = current.Next;

        }
        static void Main(string[] args)
        {

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            int k = int.Parse(Console.ReadLine());  // k tu 1-is toli iqneba ar imushavebs kodi :( 1-li node-is amogdeba calke, unda daweriliyo...

            Console.WriteLine("Before");

            Print(node1);
            Remove(node1, k);

            Console.WriteLine("After");
            Print(node1);

        }
    }

}