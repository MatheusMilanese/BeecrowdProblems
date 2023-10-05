using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double radius);
        double volume = (4.0/3.0) * 3.14159 * radius * radius * radius;

        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}