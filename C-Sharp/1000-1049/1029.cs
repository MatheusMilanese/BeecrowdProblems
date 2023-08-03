using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static int qtd = 0;

    public static int fib(int a){
        qtd++;
        if(a == 0 || a == 1) return a;
        return fib(a-1) + fib(a-2);
    }

    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        while(n-- > 0) {
            int k = Convert.ToInt32(Console.ReadLine());
            int ans = fib(k);
            Console.WriteLine($"fib({k}) = {qtd-1} calls = {ans}");
            qtd = 0;
        }
    }
}