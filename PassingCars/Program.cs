using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 0, 1, 0, 1, 1,0,1,0,1,1 };
            Console.WriteLine(solution(test));
        }

        public static int solution(int[] A)
        {

            if(A.Length > 100000)
            {
                return -1;
            }
            int count = 0;

            List<int> pairs = new List<int>();
            for(int i = A.Length - 1; i >= 0; i -= 1)
            {
                if(A[i] == 1)
                {
                    count++;
                }
                if(A[i] == 0)
                {
                    pairs.Add(count);
                }
            }
            int final = 0;
            //Add the numbers in the List
            foreach(int val in pairs)
            {
                final += val;
            }
            
            if(final > 1000000000 || final < -1000000000)
            {
                return -1;
            }
            else
            {
                return final;
            }
            

        }
    }
}
