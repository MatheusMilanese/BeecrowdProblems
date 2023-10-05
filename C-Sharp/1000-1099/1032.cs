using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static bool IsPrime(int num){
        for(int i = 2; i*i <= num; i++){
            if(num%i == 0) return false;
        }
        return true;
    }

    public static void Main(string[] args) {
        List<int> primes = new List<int>();
        for(int i = 2; i < 35000; i++){
            if(IsPrime(i)) primes.Add(i);
        }
        int n = Convert.ToInt32(Console.ReadLine());
        while(n > 0) {
            Queue<int> q = new Queue<int>();
            for(int i = 1; i <= n; i++){
                q.Enqueue(i);
            }
            int m = 0;
            while(q.Count > 1){
                for(int i = 0; i < (primes[m]-1)%q.Count; i++){
                    int aux = q.Dequeue();
                    q.Enqueue(aux);
                }
                q.Dequeue();
                m++;
            }
            
            Console.WriteLine(q.Dequeue());
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}