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
        public void PrintInOrder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");
                PrintInOrder(Root.LeftNode);
                
                PrintInOrder(Root.RightNode);
            }
        }

        public void SearchTree() 
        {
        }

    }
}
