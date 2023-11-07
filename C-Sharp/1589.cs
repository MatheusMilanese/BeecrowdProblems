using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0){
            string[] values = Console.ReadLine().Split();
            int r1 = int.Parse(values[0]);
            int r2 = int.Parse(values[1]);
            Console.WriteLine(r1+r2);
        }
    }
}