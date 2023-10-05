using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] values = Console.ReadLine().Split();
        int n = int.Parse(values[0]);
        int s = int.Parse(values[1]);
        int menor = s;
        while(n-- > 0){
            int k = int.Parse(Console.ReadLine());
            s += k;
            if(s < menor) menor = s;
        }
        Console.WriteLine(menor);
    }
}