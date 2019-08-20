using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class SearchTree
    {
        //Variables
        Node start;


        //Ctor
        public SearchTree()
        {

        }

        //Methods
        public void AddNewNode(int data)
        {
            //makes a new node for the root node
            Node nodeToAdd = new Node(data);


            if (start == null)
            {
                start = nodeToAdd;
                return;
            }

            Node node = start;
            //check if theres a node there, if nor make one          

            while (true)
            {
                if (data > node.data)
                {
                    if (node == null)
                    {
                        nodeToAdd = new Node(data);
                        node.rightChild = new Node(data);
                    }
                    else
                    {
                        node = node.rightChild;
                    }
                }
                else if (data <= node.data)
                {
                    if (node == null)
                    {
                        nodeToAdd = new Node(data);
                        node.leftChild = new Node(data);
                    }
                    else
                    {
                        node = node.leftChild;
                    }

                }
            }
        }

        //public int SearchNode()
        //{

        //}
    }
}
