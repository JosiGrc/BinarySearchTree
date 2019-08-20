using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        //Variables
        public int data;       
        public Node leftChild;
        public Node rightChild;

        //Ctor
        public Node(int data)
        {
            this.data = data;
            this.rightChild = null;
            this.leftChild = null;
        }
        
        //Methods

    }
}
