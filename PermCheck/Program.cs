using System;
using System.Collections.Generic;
using System.Linq;

namespace PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 4, 1, 3};
            Console.WriteLine(Solution(test));
        }

        public static int Solution(int[] A)
        {
            //find the max value in array
            int max = A.Max();

            //Put all elements in hashset
            HashSet<int> numHashset = new HashSet<int>();

            foreach(int value in A)
            {
                if(!numHashset.Contains(value))
                {
                    numHashset.Add(value);
                }
                else
                {
                    return 0;
                }
                
            }

            for(int i = 1; i <= max; i++)
            {
                if(!numHashset.Contains(i))
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
