using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = 5;
        int qtdPares = 0;
        while(n-- > 0){
            int k = int.Parse(Console.ReadLine());
            if((k & 1) == 0) {
                qtdPares++;
            } 
        }

        Console.WriteLine($"{qtdPares} valores pares");
    }
}