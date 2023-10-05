using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        double salario = double.Parse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture);

        double aumento;
        if(salario <= 400) aumento = 1.15;
        
        else if(salario <= 800) aumento = 1.12;
        else if(salario <= 1200) aumento = 1.1;
        else if(salario <= 2000) aumento = 1.07;
        else aumento = 1.04;

        Console.WriteLine($"Novo salario: {(aumento*salario).ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {(aumento*salario - salario).ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {Math.Round(aumento*100%100)} %");
    }
}