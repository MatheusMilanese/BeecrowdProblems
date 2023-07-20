using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static int MDC(int a, int b){
        return (b == 0) ? Math.Abs(a) : MDC(b, a%b);
    }
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        while(n-- > 0) {
            string[] input = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);
            Console.WriteLine(MDC(x, y));
        }
    }
}