using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string t = Console.ReadLine();
        string[] line = Console.ReadLine().Split(' ');
        int ans = 0;
        for(int i = 0; i < 5; i++){
            if(line[i] == t) ans++;
        }
        Console.WriteLine(ans);
    }
}