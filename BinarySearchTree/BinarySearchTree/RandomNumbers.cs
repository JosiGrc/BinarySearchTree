using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class RandomNumbers
    {
        //Variables
        public int randomNumber;

        //Ctor
        public RandomNumbers()
        {
            randomNumber = RandomNumberGenerator();
                        
        }                  

        //Methods
        public int RandomNumberGenerator()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            return randomNumber;
        }
    }
}
