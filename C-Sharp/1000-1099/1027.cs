using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string input;

        while((input = Console.ReadLine()) != null){
            int n = int.Parse(input);

            List<Tuple<int, int>> pontos = new List<Tuple<int, int>>();
            for(int i = 0; i < n; i++){
                string[] values = Console.ReadLine().Split(' ');
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);
                pontos.Add(new Tuple<int, int>(x,y));
            }

            pontos.Sort();

            int[,] dp = new int[n,2];
            dp[0,0] = 1;
            dp[0,1] = 1;
            int ans = 1;
            for(int i = 1; i < n; i++){ 
                dp[i,0] = 1;
                dp[i,1] = 1;
                for(int j = 0; j < i; j++){
                    if(pontos[j].Item1 == pontos[i].Item1) break; // acabou os pontos a esquerda do ponto j
                    if(pontos[j].Item2 - pontos[i].Item2 == 2){ // subindo de j para i
                        dp[i,1] = Math.Max(dp[i,1], dp[j, 0]+1);
                    }
                    else if(pontos[j].Item2 - pontos[i].Item2 == -2) { // descendo de j para i
                        dp[i,0] = Math.Max(dp[i,0], dp[j,1]+1);
                    }
                }
                ans = Math.Max(ans, dp[i,0]);
                ans = Math.Max(ans, dp[i,1]);
            }

            Console.WriteLine(ans);
        }
    }
}