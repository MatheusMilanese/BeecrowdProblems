using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        
        if(b <= a) Console.WriteLine($"O JOGO DUROU {24-a+b} HORA(S)");
        else Console.WriteLine($"O JOGO DUROU {b-a} HORA(S)");
    }
}