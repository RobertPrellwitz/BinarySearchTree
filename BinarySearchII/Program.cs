using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchII
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(4);
            Node node2 = new Node(2);
            Node node3 = new Node(67);
            Node node4 = new Node(6);
            Node node5 = new Node(34);
            Node node6 = new Node(34);


            Tree binaryTree = new Tree();
            binaryTree.Add(node1);
            binaryTree.Add(node2);
            binaryTree.Add(node3);
            binaryTree.Add(node4);
            binaryTree.Add(node5);
            binaryTree.Add(node6);

            binaryTree.PrintInOrder(binaryTree.TestRoot());
            Console.ReadLine();
        }
    }
}
