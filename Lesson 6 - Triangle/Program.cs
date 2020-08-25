using System;

namespace Lesson_6___Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 2, 5, 1, 8, 20 };
            Console.WriteLine(solution(test));
        }

        public static int solution(int[] A)
        {
            //Check if array has at least three elements
            if(A.Length < 3)
            {
                return 0;
            }

            //Sort the arrat
            Array.Sort(A);

            //Check if the condition is met
            for (int i = 0; i < A.Length - 2; i++)
            {
                if ((double)A[i] + (double)A[i+1] > (double)A[i+2] && (double)A[i] + (double)A[i + 2] > (double)A[i + 1] && (double)A[i + 2] + (double)A[i + 1] > (double)A[i])
                {
                    return 1;
                }
                
            }

            return 0;

        }
    }
}
