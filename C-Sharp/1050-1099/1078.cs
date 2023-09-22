using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= 10; i++){
            Console.WriteLine($"{i} x {n} = {i*n}");
        }
    }
}