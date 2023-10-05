using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n, p;
        int[,] dp = new int[21,31];
        int[] pizzas = new int[21];
        int[] tempo = new int[21];
        n = int.Parse(Console.ReadLine());
        while(n != 0){
            p = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i ++){
                string[] values = Console.ReadLine().Split();
                tempo[i] = int.Parse(values[0]);
                pizzas[i] = int.Parse(values[1]);
            }
            for(int i = 0; i <= n; i ++) dp[i,0] = 0;
            for(int i = 0; i <= p; i ++) dp[0,i] = 0;

            for(int i = 1; i <= n; i ++){
                for(int j = 1; j <= p; j++){
                    if(j >= pizzas[i] && (tempo[i] + dp[i-1,j-pizzas[i]]) > dp[i-1, j]) {
                        dp[i, j] = tempo[i] + dp[i-1, j-pizzas[i]];
                    }
                    else {
                        dp[i, j] = dp[i-1, j];
                    }
                }
            }

            Console.WriteLine($"{dp[n,p]} min.");
            n = int.Parse(Console.ReadLine());
        }
    }
}