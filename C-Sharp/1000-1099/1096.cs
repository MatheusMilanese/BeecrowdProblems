using System;
using System.Collections.Generic;
using System.Globalization;

class URI { 
    public static void Main(string[] args) {
        int i = 1;
        while(i <= 9) {
            Console.WriteLine($"I={i} J=7\nI={i} J=6\nI={i} J=5");
            i += 2;
        }
    }
}