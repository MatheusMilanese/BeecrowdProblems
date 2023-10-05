using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] values = Console.ReadLine().Split();
        int p1 = int.Parse(values[0]);
        int c1 = int.Parse(values[1]);
        int p2 = int.Parse(values[2]);
        int c2 = int.Parse(values[3]);

        Console.WriteLine(Math.Sign(p2*c2-p1*c1));
    }
}