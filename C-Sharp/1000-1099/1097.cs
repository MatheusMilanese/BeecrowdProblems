using System;
using System.Collections.Generic;
using System.Globalization;

class URI { 
    public static void Main(string[] args) {
        int i = 1, j = 7;
        while(i <= 9) {
            Console.WriteLine($"I={i} J={j}\nI={i} J={j-1}\nI={i} J={j-2}");
            i += 2;
            j += 2;
        }
    }
}