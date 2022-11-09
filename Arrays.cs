using System;

namespace Udemy
{
    public class LearnArray : FactFibo
    {
        public void learnArray()
        {
            //Declare array
            int[] tempArray;
            //Instantiate array
            tempArray = new int[3];
            //Initialize array
            tempArray[0] = 10;
            tempArray[1] = 9;
            tempArray[2] = 11;

            Console.WriteLine(string.Join(",", tempArray));

            String[] sArray = {"a", "b", "c"};
            Console.WriteLine(string.Join(",", sArray));
        }
    }
}