using System;
using System.Collections.Generic;

class URI {
    
    public static void Main(string[] args) {
        ulong n = ulong.Parse(Console.ReadLine());
        
        for(ulong i = 1; i <= n; i++){
            ulong seq2 = i*i;
            ulong seq3 = i*i*i;
            Console.WriteLine($"{i} {seq2} {seq3}");
            Console.WriteLine($"{i} {seq2+1} {seq3+1}");
        }
    }
}