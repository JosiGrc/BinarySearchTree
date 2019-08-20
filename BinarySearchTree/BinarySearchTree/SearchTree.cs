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
        public void InsertNewNode (int data)
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

            if (nodeToAdd == null)
            {
                nodeToAdd = new Node(data);     //checks if theres a node, if not one gets made
            }

            while(true)                                     
            {                
                if(data > node.data)
                {
                    node.rightChild = nodeToAdd;                  //make this part a loop for everytime a new value is added  
                }
                else if (data <= node.data)
                {
                    node.leftChild = nodeToAdd;
                }

            }           
        }
    }
}
