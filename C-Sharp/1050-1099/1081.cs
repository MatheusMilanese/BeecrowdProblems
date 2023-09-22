using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void dfs(List<List<int>> vertices, ref bool[] vis, int u, string s){
        vis[u] = true;
        foreach(int w in vertices[u]){
            if(!vis[w]){
                Console.WriteLine($"{s}{u}-{w} pathR(G,{w})");
                dfs(vertices, ref vis, w, s+"  ");
            }
            else{
                Console.WriteLine($"{s}{u}-{w}");
            }
        }
    }

    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int index = 1;
        while(n-- > 0){
            string[] values = Console.ReadLine().Split(' ');
            int v = int.Parse(values[0]);
            int e = int.Parse(values[1]);

            List<List<int>> vertices = new List<List<int>>();
            bool[] vis = new bool[v];

            for(int i = 0; i < v; i ++) vertices.Add(new List<int>());
            for(int i = 0; i < e; i ++){
                values = Console.ReadLine().Split(' ');
                int a = int.Parse(values[0]);
                int b = int.Parse(values[1]);
                vertices[a].Add(b);
            }
            for(int i = 0; i < v; i ++){
                vertices[i].Sort();
            }
            Console.WriteLine($"Caso {index++}:");
            for(int i = 0; i < v; i ++){
                if(!vis[i]) {
                    dfs(vertices, ref vis, i, "  ");
                    if(vertices[i].Count > 0) Console.WriteLine();
                }
            }
        }
    }
}