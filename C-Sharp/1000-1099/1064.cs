using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    
    public static void Main(string[] args) {
        int n = 6;
        int qtdPositivos = 0;
        float media = 0;
        while(n-- > 0){
            float k = float.Parse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture);
            if(k >= 0) {
                qtdPositivos++;
                media += k;
            } 
        }

        Console.WriteLine($"{qtdPositivos} valores positivos\n{(media/qtdPositivos).ToString("F1", CultureInfo.InvariantCulture)}");
    }
}