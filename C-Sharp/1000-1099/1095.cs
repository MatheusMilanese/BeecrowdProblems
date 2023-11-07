using System;
using System.Collections.Generic;
using System.Globalization;

class URI { 
    public static void Main(string[] args) {
        int i = 1, j = 60;
        while(j >= 0) {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
            j -= 5;
        }
    }
}