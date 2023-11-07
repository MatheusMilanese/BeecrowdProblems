using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static int Findmatch(int i, ref bool[] vis, ref int[] match, List<int>[] adj){
        if(vis[i]) return 0;
        vis[i] = true;

        for(int k = 0; k < adj[i].Count; k++){
            int u = adj[i][k];
            if(match[u] == -1 || Findmatch(match[u], ref vis, ref match, adj) == 1){
                match[u] = i;
                return 1;
            }
        }
        return 0;
    }


    public static void Main(string[] args) {
        int index = 1;
        int[] A, B, match;
        bool[] vis;
        List<int>[] adj;
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0){
            string[] values = Console.ReadLine().Split();
            int k1 = int.Parse(values[0]);
            A = new int[k1];
            for(int i = 1; i <= k1; i++){
                A[i-1] = int.Parse(values[i]);
            }
            
            values = Console.ReadLine().Split();
            int k2 = int.Parse(values[0]);
            B = new int[k2];
            for(int i = 1; i <= k2; i++){
                B[i-1] = int.Parse(values[i]);
            }

            vis = new bool[k1];
            match = new int[k2];
            adj = new List<int>[k1];

            for(int i = 0; i < k2; i++) match[i] = -1;
            for(int i = 0; i < k1; i++){
                adj[i] = new List<int>();
                for(int j = 0; j < k2; j++){
                    if(B[j] == 0) adj[i].Add(j);
                    else if(A[i] != 0 && B[j]%A[i] == 0) adj[i].Add(j);
                }
            }
            
            int ans = 0;

            for(int i = 0; i < k1; i++){
                for(int j = 0; j < k1; j++){
                    vis[j] = false;
                }
                ans += Findmatch(i, ref vis, ref match, adj);
            }

            Console.WriteLine($"Case {index++}: {ans}");
        }
    }
}