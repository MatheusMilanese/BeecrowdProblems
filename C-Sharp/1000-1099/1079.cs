using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++){
            string line = Console.ReadLine();
            string[] values = line.Split(' ');
            double a = double.Parse(values[0], NumberStyles.Number, CultureInfo.InvariantCulture);
            double b = double.Parse(values[1], NumberStyles.Number, CultureInfo.InvariantCulture);
            double c = double.Parse(values[2], NumberStyles.Number, CultureInfo.InvariantCulture);

            double ans = (a * 2 + b * 3 + c * 5) / 10;

            Console.WriteLine(ans.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}