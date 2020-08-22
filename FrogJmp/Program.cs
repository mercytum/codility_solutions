using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10,85,30));
        }

        public static int solution(int X, int Y, int D)
        {
            if(X >= Y)
            {
                return 0;
            }

            int distanceToCover = Y - X;
            int jumpsMade = distanceToCover / D;
            if(distanceToCover % D != 0)
            {
                jumpsMade++;
            }
            return jumpsMade;
        }
    }
}
