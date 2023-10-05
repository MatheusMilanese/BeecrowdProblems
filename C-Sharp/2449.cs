using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] values = Console.ReadLine().Split();
        int n = int.Parse(values[0]);
        int m = int.Parse(values[1]);
        values = Console.ReadLine().Split();
        int[] v = new int[n];

        for(int i = 0; i < n; i++){
            v[i] = int.Parse(values[i]);
        }

        int ans = 0;
        for(int i = 1; i < n; i++){
            if(v[i-1] == m) continue;
            if(v[i-1] < m) {
                v[i] += Math.Abs(m-v[i-1]);
                ans += Math.Abs(m-v[i-1]);
            }
            else{
                v[i] -= Math.Abs(m-v[i-1]);
                ans += Math.Abs(m-v[i-1]);
            }
        }
        Console.WriteLine(ans);
    }
}