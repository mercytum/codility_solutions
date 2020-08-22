using System;
using System.Collections.Generic;

namespace OddOccurenceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 9, 3, 9, 3, 9, 7, 9 };
            Console.WriteLine(solution(test));
        }

        public static long solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //Place all value in the array in a dictionary
            Dictionary<long, long> ADict = new Dictionary<long, long>();

            foreach (int value in A)
            {
                if (!ADict.ContainsKey(value))
                {
                    ADict.Add((long)value, 1);
                }
                else
                {
                    ADict[(long)value]++;
                }
            }
            long num = 0;
            foreach (KeyValuePair<long, long> kvp in ADict)
            {
                if (kvp.Value %2 != 0)
                {
                    num = kvp.Key;
                }
            }

            return num;
        }
    }
}
