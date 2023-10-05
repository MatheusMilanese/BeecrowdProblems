using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        while(n-- > 0){
            int k = int.Parse(Console.ReadLine());
            if(k == 0){
                Console.WriteLine("NULL");
                continue;
            } 

            if((k&1) == 1) Console.Write("ODD ");
            else Console.Write("EVEN ");

            if(k > 0) Console.Write("POSITIVE\n");
            else Console.Write("NEGATIVE\n");
        }
    }
}