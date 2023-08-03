using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        string[] input = Console.ReadLine().Split(' ');
        double.TryParse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double x1);
        double.TryParse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double y1);

        input = Console.ReadLine().Split(' ');
        double.TryParse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double x2);
        double.TryParse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double y2);

        double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

        Console.WriteLine($"{dist.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}