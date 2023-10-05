using System;

class URI {
    static void Main(string[] args){
        string[] input = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(input[0]);
        int B = Convert.ToInt32(input[1]);
        int C = Convert.ToInt32(input[2]);

        int ans = (A + B + Math.Abs(A-B))/2;
        ans = (ans + C + Math.Abs(ans-C))/2;

        Console.WriteLine($"{ans} eh o maior");
    }
}