using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] values = Console.ReadLine().Split();
        int c = int.Parse(values[0]);
        int n = int.Parse(values[1]);

        Console.WriteLine(c%n);
    }
}