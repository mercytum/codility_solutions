using System;
using System.Collections.Generic;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Solution(6,11,2));
            Console.WriteLine(Solution(11, 345, 17));
            Console.WriteLine(Solution(10, 10, 5));
            Console.WriteLine(Solution(0, 14, 2));
            Console.WriteLine(Solution(0, 13, 2));
        }

        public static int Solution(int A, int B, int K)
        {

            int count = 0;

            //If A is divisible by K
            if(A % K == 0)
            {
                count = (B / K) - (A / K) + 1;
            }
            //If A is not divisible by K
            else if(A % K != 0)
            {
                count = (B / K) - (A / K);
            }

            return count;

            ///Other way to do it, though not as effecient 
            //int count = 0;

            //if(B > K)
            //{
            //    for (int i = A; i <= B; i += K)
            //    {

            //        count++;
            //    }
            //    return count;
            //}            

            //return count;

        }
    }
}
