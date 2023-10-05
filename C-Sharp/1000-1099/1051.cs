using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        double salario = double.Parse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture);

        double ans = 0;;

        if(salario > 4500){
            ans += (salario-4500)*0.28;
            salario -= (salario-4500);
        } 
        if(salario > 3000){
            ans += (salario-3000)*0.18;
            salario -= (salario-3000);
        } 
        if(salario > 2000){
            ans += (salario-2000)*0.08;
            salario -= (salario-2000);
        } 
        
        if(ans > 0) Console.WriteLine($"R$ {ans.ToString("F2", CultureInfo.InvariantCulture)}");
        else Console.WriteLine("Isento");
    }
}