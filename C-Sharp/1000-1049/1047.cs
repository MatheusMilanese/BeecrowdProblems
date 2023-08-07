using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        
        int h1 = int.Parse(input[0]);
        int m1 = int.Parse(input[1]);
        int h2 = int.Parse(input[2]);
        int m2 = int.Parse(input[3]);
        
        int t1 = h1*60+m1;
        int t2 = h2*60+m2;

        int t;
        if(t2 <= t1) t = 1440-t1+t2;
        else t = t2-t1;

        Console.WriteLine($"O JOGO DUROU {t/60} HORA(S) E {t%60} MINUTO(S)");
    }
}