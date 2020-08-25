using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { -3, 1, 2, -2, 5, 6 };
            Console.WriteLine(solution(test));
        }

        public static int solution(int[] A)
        {
            Array.Sort(A);
            int lastIndex = A.Length - 1;
            //From the back
            int last = A[lastIndex];
            int secondLast = A[lastIndex - 1];
            int thirdLast = A[lastIndex - 2];

            int productBack = last * secondLast * thirdLast;

            //From the front
            int first = A[0];
            int second = A[1];

            int productFront = first * second * last;

            if(productBack > productFront)
            {
                return productBack;
            }
            else
            {
                return productFront;
            }

            
        }
    }
}
