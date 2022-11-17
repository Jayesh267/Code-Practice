using System;

namespace Udemy
{
    public class DoubleDimensionalArray
    {
        public void traverse2DArray()
        {
            int rowLen = arr2.GetLength(0);
            int colLen = arr2.GetLength(1);

            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    Console.WriteLine(string.Format("{0} ", arr2[i][j]));
                }
                Console.WriteLine();
            }
        }
    }
}