using System;
using System.Collections.Generic;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 2, 3, 5, 4 };
            Console.WriteLine(solution(5, test));
        }

        public static int solution(int X, int[] A)
        {
            HashSet<int> numsSet = new HashSet<int>();
            for(int i = 1; i <= X; i++)
            {
                numsSet.Add(i);
            }
            for(int i = 0; i < A.Length; i++)
            {
                if(numsSet.Contains(A[i]))
                {
                    numsSet.Remove(A[i]);
                }

                if(numsSet.Count == 0)
                {

                    return i;
                }
            }
            return -1;
                     

        }
    }
}


