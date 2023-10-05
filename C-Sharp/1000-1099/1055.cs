using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());
        int index = 1;
        while(t-- > 0) {
            //Leitura da entrada
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            List<int> list = new List<int>();
            for(int i = 1; i <= n; i++) {
                list.Add(int.Parse(input[i]));
            }

            //ordenando a lista
            list.Sort();

            //caso 1
            int[] permutation1 = new int[n];
            int k = 1, j = 0;
            while(k < n-1){
                permutation1[k] = list[j++];
                k += 2;
            }
            permutation1[n-1] = list[j++];
            permutation1[0] = list[j++];
            k = 2;
            while(j < n){
                permutation1[k] = list[j++];
                k += 2;
            }

            int case1 = 0;
            for(int i = 0; i < n-1; i++) case1 += Math.Abs(permutation1[i]-permutation1[i+1]);
            
            //caso 2
            int[] permutation2 = new int[n];
            k = 1;
            j = n-1;
            while(k < n-1){
                permutation2[k] = list[j--];
                k += 2;
            }
            permutation2[n-1] = list[j--];
            permutation2[0] = list[j--];
            k = 2;
            while(j >= 0){
                permutation2[k] = list[j--];
                k += 2;
            }

            int case2 = 0;
            for(int i = 0; i < n-1; i++) case2 += Math.Abs(permutation2[i]-permutation2[i+1]);

            // Console.WriteLine(string.Join(" ", permutation));
            
            Console.WriteLine($"Case {index++}: {Math.Max(case1, case2)}");
            
        }
    }
}