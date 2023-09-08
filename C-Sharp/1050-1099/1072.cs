using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int dentro = 0, fora = 0;

        while(n-- > 0){
            int k = int.Parse(Console.ReadLine());
            if(k >= 10 && k <= 20) dentro++;
            else fora++;
        }

        Console.WriteLine($"{dentro} in\n{fora} out");
    }
}