using System;
using System.Collections.Generic;
using System.Linq;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 2, 3, 1, 5 };
            Console.WriteLine(Solution(test));
        }

        public static int Solution(int[] A)
        {
            SortedDictionary<int, int> sortedNumsDict = new SortedDictionary<int, int>();

            foreach(int value in A)
            {
                sortedNumsDict.Add(value, 1);
            }

            int missing = 0;
            for(int i = 1; i <= A.Length+1; i++ )
            {
                if(!sortedNumsDict.ContainsKey(i))
                {
                    missing = i;
                }
            }

            return missing;
        }
    }
}
