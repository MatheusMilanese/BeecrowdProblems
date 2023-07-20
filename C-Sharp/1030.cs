using System;
using System.Collections.Generic;
using System.Globalization;

class URI {


    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int index = 1;
        while(n-- > 0) {
            string[] input = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);
            Queue<int> q = new Queue<int>();
            for(int i = 1; i <= x; i++){
                q.Enqueue(i);
            }
            while(q.Count > 1){
                for(int i = 1; i < y; i++){
                    int aux = q.Dequeue();
                    q.Enqueue(aux);
                }
                q.Dequeue();
            }

            Console.WriteLine($"Case {index++}: {q.Dequeue()}");
        }
    }
}