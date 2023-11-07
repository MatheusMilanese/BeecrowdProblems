using System;
using System.Collections.Generic;
using System.Globalization;

class URI { 
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        while(n-- > 0){
            string[] line = Console.ReadLine().Split();
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);

            if(x > y){
                x += y;
                y = x-y;
                x -= y;
            }
            x++;
            y--;
            if((x&1) == 0) x++;
            if((y&1) == 0) y--;

            // 11 11 = 
            if(x > y) Console.WriteLine(0);
            else{
                int k = (y-x)/2 + 1;
                Console.WriteLine((x+y)*k/2);
            }
        }
    }
}