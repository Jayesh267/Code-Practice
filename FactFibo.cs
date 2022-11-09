using System;

namespace Udemy
{
    public class FactFibo
    {
        public static void Main(string[] args)
        {
            FactFibo p1 = new FactFibo();
            var factorialResult = p1.factorial(0);
            Console.WriteLine(factorialResult);

            var fibonacciResult = p1.fibonacci(-3);
            Console.WriteLine(fibonacciResult);

            SumOfDigits p2 = new SumOfDigits();
            var sumDigitsResult = p2.sumOfDigits(427);
            Console.WriteLine(sumDigitsResult);

            Power p3 = new Power();
            var powerResult = p3.npower(2, 4);
            Console.WriteLine(powerResult);

            GCD p4 = new GCD();
            var gcdResult = p4.gcd(8, -12);
            Console.WriteLine(gcdResult);

            DecimalBinary p5 = new DecimalBinary();
            var binaryResult = p5.decimalBinary(134);
            Console.WriteLine(binaryResult);

            LearnArray p6 = new LearnArray();
            p6.learnArray();
        }

        //Recursive method to find factorial
        public int factorial (int n)
        {
            if (n<0)
            {
                return -1;
            }
            if (n==0 || n==1)
            {
                return 1;
            }
            //Console.WriteLine(n);
            return n * factorial(n-1);
        }
        
        //Recursive method for fibonacci sequence
        public int fibonacci (int n)
        {
            if (n<0)
            {
                return -1;
            }
            if (n==0 || n==1)
            {
                return n;
            }
            return fibonacci(n-1) + fibonacci(n-2);
        }
    }
}
