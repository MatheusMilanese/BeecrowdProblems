using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        if((n&1) == 0) n++;
        Console.WriteLine($"{n}\n{n+2}\n{n+4}\n{n+6}\n{n+8}\n{n+10}");
    }
}