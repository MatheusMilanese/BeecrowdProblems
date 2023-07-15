using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static void Main(string[] args){
        string[] input = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(input[0]);
        int q = Convert.ToInt32(input[1]);
        int qtdCases = 1;
        while(n != 0 && q != 0){
            List<int> marbles = new List<int>();
            for(int i = 0; i < n; i++){
                int num = Convert.ToInt32(Console.ReadLine());
                marbles.Add(num);
            }
            marbles.Sort();
            Console.WriteLine($"CASE# {qtdCases++}:");
            for(int i = 0; i < q; i++){
                int query = Convert.ToInt32(Console.ReadLine());
                int index = marbles.FindIndex(0, marbles.Count, x => x == query);
                if(index == -1)
                    Console.WriteLine($"{query} not found");
                else
                    Console.WriteLine($"{query} found at {index+1}");
            }
            marbles.Clear();
            input = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(input[0]);
            q = Convert.ToInt32(input[1]);
        }
    } 
}