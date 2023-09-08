using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int i = 2;
        while(i <= n){
            Console.WriteLine($"{i}^2 = {i*i}");
            i += 2;
        }
    }
}