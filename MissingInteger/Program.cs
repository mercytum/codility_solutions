using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 3, 6, 4, 1, 2 };
            Console.WriteLine(Solution(test));
        }

        public static int Solution(int[] A)
        {
            int max = A.Max();
            if (max > 0)
            {
                Dictionary<int, int> numDict = new Dictionary<int, int>();
                for (int i = 1; i <= max; i++)
                {
                    numDict.Add(i, 1);
                }

                for (int i = 0; i < A.Length; i++)
                {
                    if (numDict.ContainsKey(A[i]))
                    {
                        numDict.Remove(A[i]);
                    }
                }

                if (numDict.Count > 0)
                {
                    foreach (int value in numDict.Keys)
                    {
                        return value;

                    }
                }
                
                if(numDict.Count ==0)
                {
                    return max + 1;
                }

            }

            return 1;

        }
    }
}
