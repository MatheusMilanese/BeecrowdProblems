using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if(b < a){
            a += b;
            b = a - b;
            a -= b;
        }

        int ans = 0;
        a++;
        while(a < b) {
            ans += (a&1) * a;
            a++;
        }

        Console.WriteLine(ans);
    }
}