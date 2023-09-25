using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static List<List<int>> vertices;
    static bool[] vis;
    static List<int> ans;

    public static void dfs(int u){
        vis[u] = true;
        ans.Add(u);
        foreach(int w in vertices[u]){
            if(!vis[w]){
                dfs(w);
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

            vertices = new List<List<int>>();
            vis = new bool[v];

            for(int i = 0; i < v; i ++) vertices.Add(new List<int>());
            for(int i = 0; i < e; i ++){
                values = Console.ReadLine().Split(' ');
                int a = char.Parse(values[0]) - 'a';
                int b = char.Parse(values[1]) - 'a';
                vertices[a].Add(b);
                vertices[b].Add(a); 
            }
            
            Console.WriteLine($"Case #{index++}:");
            int k = 0;
            for(int i = 0; i < v; i ++){
                if(!vis[i]) {
                    k++;
                    ans = new List<int>(26);
                    dfs(i);
                    ans.Sort();
                    for(int j = 0; j < ans.Count; j++){
                        Console.Write((char)(ans[j]+97)+",");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"{k} connected components\n");
        }
    }
}