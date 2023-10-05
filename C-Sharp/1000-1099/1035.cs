using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);

        if(b > c && d > a && (c+d > a+b) && c >= 0 && d >= 0 && (a & 1) == 0)
            Console.WriteLine("Valores aceitos");
        else{
            Console.WriteLine("Valores nao aceitos");
        }
    }
}