using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        while(n != 0){
            string[] line = Console.ReadLine().Split();
            int x0 = int.Parse(line[0]);
            int y0 = int.Parse(line[1]);
            for(int i = 0; i < n; i++){
                line = Console.ReadLine().Split();
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if(x == x0 || y == y0) Console.WriteLine("divisa");
                else if(x > x0){
                    if(y > y0) Console.WriteLine("NE");
                    else Console.WriteLine("SE");
                }
                else{
                    if(y > y0) Console.WriteLine("NO");
                    else Console.WriteLine("SO");
                }
            }
            n = int.Parse(Console.ReadLine());
        }

    }
}