using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double.TryParse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double a);
        double.TryParse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double b);
        double.TryParse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double c);

        double delta = b*b - 4*a*c;
        if(delta < 0 || a == 0){
            Console.WriteLine("Impossivel calcular");
        }
        else{
            double x1 = (-b + Math.Sqrt(delta)) / (2*a);
            double x2 = (-b - Math.Sqrt(delta)) / (2*a);

            Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}