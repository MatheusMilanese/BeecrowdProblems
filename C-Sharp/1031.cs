using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        while(n > 0) {
            int ans = 1;
            Queue<int> q = new Queue<int>();
            while(true){
                for(int i = 2; i <= n; i++){
                    q.Enqueue(i);
                }
                while(q.Count > 1){
                    for(int i = 1; i < ans; i++){
                        int aux = q.Dequeue();
                        q.Enqueue(aux);
                    }
                    q.Dequeue();
                }
                if(q.Dequeue() == 13) break;
                else ans++;
            }
            Console.WriteLine(ans);
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}