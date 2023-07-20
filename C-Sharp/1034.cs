using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    
    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0) {
            string[] input  = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] v = new int[n];

            input = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++){
                v[i] = (int.Parse(input[i]));
            }
            int[] dp = new int[m+1];
            dp[0] = 0;
            dp[1] = 1;

            for(int i = 2; i <= m; i++){
                dp[i] = 0x3F3F3F3F;
                for(int j = 0; j < n; j++){
                    if(v[j] <= i && dp[(i-v[j])] + 1 < dp[i])
                        dp[i] = dp[(i-v[j])] + 1;
                }
            }
            
            Console.WriteLine(dp[m]);
        }
    }
}