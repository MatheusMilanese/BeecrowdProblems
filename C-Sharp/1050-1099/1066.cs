using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = 5;
        int pares = 0, impares = 0, positivos = 0, negativos = 0;
        while(n-- > 0){
            int k = int.Parse(Console.ReadLine());
            
            if((k & 1) == 0) pares++;
            else impares++;

            if(k > 0) positivos++;
            else if(k < 0) negativos++;
        }

        Console.WriteLine($"{pares} valor(es) par(es)\n{impares} valor(es) impar(es)\n{positivos} valor(es) positivo(s)\n{negativos} valor(es) negativo(s)");
    }
}