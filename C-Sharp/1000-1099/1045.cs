using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        
        double a = double.Parse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture);
        double b = double.Parse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture);
        double c = double.Parse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture);

        if(a < b){
            a += b;
            b = a - b;
            a -= b;
        }
        if(a < c){
            a += c;
            c = a - c;
            a -= c;
        }

        if(a >= b+c){
            Console.WriteLine("NAO FORMA TRIANGULO");
            return;
        }
        if(a*a == (b*b + c*c)) Console.WriteLine("TRIANGULO RETANGULO");
        else if(a*a > (b*b + c*c)) Console.WriteLine("TRIANGULO OBTUSANGULO");
        else Console.WriteLine("TRIANGULO ACUTANGULO");

        if(a == b && b == c) Console.WriteLine("TRIANGULO EQUILATERO");
        else if(a == b || b == c || a == c) Console.WriteLine("TRIANGULO ISOSCELES");
    }
}