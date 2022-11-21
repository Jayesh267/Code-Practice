using System;

namespace Udemy
{
    public class DoubleDimensionalArray
    {
        public DoubleDimensionalArray()
        {

        }

        public void traverse2DArray()
        {
            //Display 2D Array

            //Step 1 - Declare
            int[,] arr2 = new int[2, 3];

            //Step 3 - Initialize
            arr2[0, 0] = 2;
            arr2[0, 1] = 3;
            arr2[1, 0] = 6;
            arr2[1, 1] = 7;
            int rowLen = arr2.GetLength(0);
            int colLen = arr2.GetLength(1);

            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    Console.WriteLine(string.Format("{0} ", arr2[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}