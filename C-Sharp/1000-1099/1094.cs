using System;
using System.Collections.Generic;
using System.Globalization;

class URI { 
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[3]{0,0,0};
        while(n-- > 0){
            string[] line = Console.ReadLine().Split();
            switch(line[1]){
                case "C":
                    v[0] += int.Parse(line[0]);
                    break;
                case "R":
                    v[1] += int.Parse(line[0]);
                    break;
                case "S":
                    v[2] += int.Parse(line[0]);
                    break;
            }
        }
        int totalCobaias = v[0] + v[1] + v[2];
        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {v[0]}");
        Console.WriteLine($"Total de ratos: {v[1]}");
        Console.WriteLine($"Total de sapos: {v[2]}");
        Console.WriteLine($"Percentual de coelhos: {((double)v[0]/totalCobaias*100).ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {((double)v[1]/totalCobaias*100).ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {((double)v[2]/totalCobaias*100).ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}