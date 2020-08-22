using System;
using System.Collections.Generic;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int solution(int[] A)
        {
            HashSet<int> distinctNums = new HashSet<int>();

            foreach(int value in A)
            {
                distinctNums.Add(value);
            }

            return distinctNums.Count;
        }
    }
}
