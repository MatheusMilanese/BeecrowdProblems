using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        string[] input = Console.ReadLine().Split(' ');

        double.TryParse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double A);
        double.TryParse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double B);
        double.TryParse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double C);

        Console.WriteLine($"TRIANGULO: {(A*C/2).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {(3.14159*C*C).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {((A+B)*C/2).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {(B*B).ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {(A*B).ToString("F3", CultureInfo.InvariantCulture)}");
    }
}