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
                    if (node.rightChild == null)
                    {
                        node.rightChild = nodeToAdd;
                        break;
                    }
                    else
                    {
                        node = node.rightChild;
                    }
                }
                else if (data <= node.data)
                {
                    if (node.leftChild == null)
                    {
                        node.leftChild = nodeToAdd;
                        break;
                    }
                    else
                    {
                        node = node.leftChild;
                    }
                }
            }            
        }
        /// ////////////////////////////////////
        /// //SearchMethod
        public int SearchNode() //When the search function is called the int will be brought along with the its parent and child nodes
        {
            
        }
    }
}
