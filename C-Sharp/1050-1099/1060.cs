using System;

class URI {
    
    public static void Main(string[] args) {
        
        int qtdPositivos = 0;
        double n;
        for(int i = 0; i < 6; i++){
            n = double.Parse(Console.ReadLine());
            if(n > 0) qtdPositivos++;
        }

        Console.WriteLine($"{qtdPositivos} valores positivos");
    }
}