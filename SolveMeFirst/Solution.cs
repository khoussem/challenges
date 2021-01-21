using System;

namespace challenges.SolveMeFirst
{
    class Solution
    {
        public static int Solve(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = Solve(val1,val2);
            Console.WriteLine(sum);
        }
    }
}
