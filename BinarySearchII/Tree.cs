using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchII
{
    class Tree
    {
        public Node RootNode { get; set; }
        public Node LastNode { get; set; }
        //public Node RigtNode { get; set; }
        //public Node LeftNode { get; set; }
        public Node NextNode { get; set; }

        public int data { get; set; }



        public Tree()
        {
            RootNode = null;
        }

        public void Add(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
                LastNode = RootNode;
            }
            else 
            {
                LastNode = RootNode;
               
                Node NextNode;

                while (true)
                {
                    NextNode = LastNode;
                    if (nodeToAdd.Data < LastNode.Data)
                    {
                        LastNode = LastNode.LeftNode;
                        if (LastNode == null)
                        {
                            NextNode.LeftNode = nodeToAdd;
                            
                            return;
                        }
                    }
                    else
                    {
                        LastNode = LastNode.RightNode;
                            if(LastNode == null)
                        {
                            NextNode.RightNode = nodeToAdd;
                            
                            return;
                        }
                    }
                }
                
            }

        }
        public Node TestRoot()
        {
            return RootNode;
        }

        // prints the tree
        public void PrintInOrder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");
                PrintInOrder(Root.LeftNode);
                PrintInOrder(Root.RightNode);
            }
        }
        // prints the left side
        public void PrintLeft(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");
                PrintLeft(Root.LeftNode);
               
            }
        }
        // prints the right side
        public void PrintRight(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");
                PrintRight(Root.RightNode);
            }
        }


        public Node SearchTree(Node nodeToFind) 
        {
            if (RootNode != null)
            {
                LastNode = RootNode;
                if (LastNode == nodeToFind)
                {
                    return RootNode;
                }
                else 
                {
                    while (true)
                    {
                        if (nodeToFind.Data < LastNode.Data)
                        {
                            LastNode = LastNode.LeftNode;
                            return LastNode;

                        }
                        else
                        {
                            LastNode = LastNode.RightNode;
                            return LastNode;
                        }
                        
                    }
                    
                }

            }
            return LastNode;
        }

    }
}
