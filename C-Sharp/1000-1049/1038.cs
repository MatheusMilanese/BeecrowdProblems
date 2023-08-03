using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        double[] menu = new double[]{4.0, 4.5, 5.0, 2.0, 1.5};
        string[] input = Console.ReadLine().Split(' ');
        int cod = int.Parse(input[0]);
        int qtd = int.Parse(input[1]);
        double ans = menu[cod-1] * qtd;
        Console.WriteLine($"Total: R$ {ans.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}