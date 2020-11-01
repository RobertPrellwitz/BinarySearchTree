using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchII
{
    class Node
    {
        public int Data;

        public Node NextNode;
        public Node RightNode;
        public Node LeftNode;



        public Node(int data)
        {
            Data = data;
        }

    }
}
