using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        if(b < a){
            a += b;
            b = a - b;
            a -= b;
        }
        if(b%a == 0) Console.WriteLine("Sao Multiplos");
        else Console.WriteLine("Nao sao Multiplos");
    }
}