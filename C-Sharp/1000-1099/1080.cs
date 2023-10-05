using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int maior = -1, index = -1;
        for(int i = 1; i <= 100; i++){
            int k = int.Parse(Console.ReadLine());
            if(k > maior){
                maior = k;
                index = i;
            }
        }
        Console.WriteLine($"{maior}\n{index}");
    }
}