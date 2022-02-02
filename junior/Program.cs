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
            int elementMoving = 0;
            int objectOne;
            int objectTwo;

            for (int i = 0; i < array.Length)
            {
                elementMoving = random.Next(0, array.Length);

                if (i != elementMoving)
                {
                    objectOne = array[i];
                    objectTwo = array[elementMoving];

                    array[i] = objectTwo;
                    array[elementMoving] = objectOne;

                    i++;
                }
            }
            return array;
        }
    
    }
}