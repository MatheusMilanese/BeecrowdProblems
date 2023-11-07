using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static int f(int l, int n, int m, List<int> v){
        int ans = 0, qtd = 0, p1 = 0, p2 = v.Count-1;
        if(n*100%l != 0) return 99999999;
        while(p1 <= p2 && qtd < n*100/l){
            if(v[p2] == m){
                p2--;
                qtd++;
                ans++;
            }
            else if(v[p1] == m){
                p1++;
                qtd++;
                ans++;
            }
            else if(p1 == p2) break;
            else if(v[p1] + v[p2] == m){
                p1++;
                p2--;
                qtd++;
                ans += 2;
            }
            else if(v[p1] + v[p2] > m) p2--;
            else p1++;
        }
        if(qtd == n*100/l) return ans;
        return 99999999;
    }

    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        while(n != 0 && m != 0){
            int l = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            input = Console.ReadLine().Split();
            List<int> v = new List<int>();
            for(int i = 0; i < k; i++){
                v.Add(int.Parse(input[i]));
            }
            v.Sort();
            int ans1 = f(l, n, m, v);
            int ans2 = f(l, m, n, v);

            if(ans1 != 99999999 || ans2 != 99999999) Console.WriteLine(Math.Min(ans1, ans2));
            else Console.WriteLine("impossivel");
            input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);
        }
    }
}