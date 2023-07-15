using System;
using System.Globalization;

class URI {
    public static int MDC(int a, int b) {
        return (b == 0) ? Math.Abs(a) : MDC(b, a%b);
    }

    static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        while(n-- > 0){
            int N1, D1, N2, D2;
            string op;


            string[] input = Console.ReadLine().Split(' ');
            N1 = Convert.ToInt32(input[0]);
            D1 = Convert.ToInt32(input[2]);
            N2 = Convert.ToInt32(input[4]);
            D2 = Convert.ToInt32(input[6]);

            op = input[3];
            int ans1, ans2;
            if(op == "+"){
                ans1 = (N1*D2 + N2*D1);
                ans2 = (D1*D2);
            }
            else if(op == "-"){
                ans1 = (N1*D2 - N2*D1);
                ans2 = (D1*D2);
            }
            else if(op == "*"){
                ans1 = (N1*N2);
                ans2 = (D1*D2);
            }
            else{
                ans1 = (N1*D2);
                ans2 = (N2*D1);
            }

            int div = MDC(ans1, ans2);

            Console.WriteLine($"{ans1}/{ans2} = {ans1/div}/{ans2/div}");
        }
    } 
}