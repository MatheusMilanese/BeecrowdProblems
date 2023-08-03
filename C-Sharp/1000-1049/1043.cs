using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        
        double x = double.Parse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture);
        double y = double.Parse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture);
        double z = double.Parse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture);
        
        double a = x;
        double b = y;
        double c = z;
        if(x < y){
            x += y;
            y = x - y;
            x -= y;
        }
        if(x < z){
            x += z;
            z = x - z;
            x -= z;
        }
        if(y + z > x) Console.WriteLine($"Perimetro = {(x+y+z).ToString("F1", CultureInfo.InvariantCulture)}");
        else Console.WriteLine($"Area = {(((a+b)*c)/2).ToString("F1", CultureInfo.InvariantCulture)}");
        
    }
}