using System;

public class Power : FactFibo
{
    //find power of a number
    public int npower(int n, int exp)
    {
        if (n==1)
        {
            return 1;
        }
        return n * npower(n, exp-1);
    }
}