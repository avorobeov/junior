using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junior
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] nambers = {1,2,3,4,5,6,7,8,9,10 };

            nambers = Shuffele(nambers);

        }
        static int [] Shuffele(int[] array)
        {
            Random random = new Random();
            int elementNumber = 0;
            int elementMoving = 0;
            int objectOne;
            int objectTwo;

            while (elementNumber != array.Length)
            {
                elementMoving = random.Next(0, array.Length);

                if (elementNumber != elementMoving)
                {
                    objectOne = array[elementNumber];
                    objectTwo = array[elementMoving];

                    array[elementNumber] = objectTwo;
                    array[elementMoving] = objectOne;

                    elementNumber++;
                }
            }
            return array;
        }
    
    }
}