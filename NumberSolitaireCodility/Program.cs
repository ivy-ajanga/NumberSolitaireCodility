using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] A = { 1, -2, 0, 9, -1, -2 };
        Console.WriteLine(solution(A));
    }
    public static int solution(int[] A)
    {
        //initialize new array 
        int[] dp = new int[A.Length];
        //assign the first element of array to first element of given array
        dp[0] = A[0];
        int N = A.Length;
        for (int i = 1; i < N; i++)
        {
            dp[i] = int.MinValue;
            for (int j = 1; j <= 6; j++)
            {
                if (j <= i)
                {
                    dp[i] = Math.Max(dp[i], dp[i - j]);
                }
                else
                {
                    break;
                }

            }
            dp[i] += A[i];
        }
        return dp[N - 1];
    }
}