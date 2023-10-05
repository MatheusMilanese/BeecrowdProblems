using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string line;
        long n, sum;
        long[] v, dp;
        while((line = Console.ReadLine()) != null){
            n = long.Parse(line);
            v = new long[n];
            dp = new long[n];
            sum = 0;
            string[] values = Console.ReadLine().Split();
            for(long i = 0; i < n; i ++){
                v[i] = long.Parse(values[i]);
                dp[i] = v[i];
                sum += v[i];
            }
            
            for(long i = 2; i <= n; i++){
                for(int j = 0; j < n-i+1; j++){
                    dp[j] = Math.Max(v[j]-dp[j+1], v[j+i-1] - dp[j]);
                }
            }

            Console.WriteLine((dp[0]+sum)/2);
        }
    }
}