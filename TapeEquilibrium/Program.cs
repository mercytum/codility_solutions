using System;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3, 1, 2, 4, 3 };
            Console.WriteLine(solution(test));
        }

        public static int solution(int[] A)
        {
            int smallestDiff = int.MaxValue;
            int totalSum = 0;
            
            foreach(int value in A)
            {
                totalSum += value;
            }

            int firstPart = 0;
            int secondPart = 0;

            int diff = 0;

            for(int P = 0; P < A.Length - 1; P++)
            {
                firstPart += A[P];
                secondPart = totalSum - firstPart;
                diff = Math.Abs(firstPart - secondPart);
                smallestDiff = Math.Min(smallestDiff, diff);
            }

            return smallestDiff;
        }

    }
}
