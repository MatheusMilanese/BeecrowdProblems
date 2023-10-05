using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static long fib(long n, long mod) {
        long a, b, p, q;
        a = q = 1;
        b = p = 0;
        while (n > 0) {
            if ((n & 1) == 0) {
                long qq = q*q%mod;
                q = 2*p%mod*q%mod + qq;
                p = p*p%mod + qq;
                n /= 2;
            } else {
                long aq = a*q%mod;
                a = ((b*q%mod) + aq)%mod + (a*p%mod);
                b = b*p%mod + aq;
                n -= 1;
            }
            // Console.WriteLine($"{a} {b} {p} {q}");
        }
        return b;
    }

    public static void Main(string[] args) {
        string[] values = Console.ReadLine().Split();
        long a = int.Parse(values[0]);
        long b = int.Parse(values[1]);
        long index = 1;
        while(b != 0){
            long aux = a > 1 ? 2*fib(a+1, b)-1 : 1;
            Console.WriteLine($"Case {index++}: {a} {b} {(aux%b+b)%b}");
            values = Console.ReadLine().Split();
            a = int.Parse(values[0]);
            b = int.Parse(values[1]);
        }
    }
}