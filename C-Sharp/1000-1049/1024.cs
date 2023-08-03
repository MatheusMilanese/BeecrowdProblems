using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        while(n-- > 0){
            string input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++){
                if((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122)){
                    input = input.Substring(0, i) + (char)(input[i]+3) + input.Substring(i+1);
                }
            }

            int j = 0, k = input.Length-1;
            while(j < k){
                char aux = input[j];
                input = input.Substring(0, j) + (input[k]) + input.Substring(j+1);
                input = input.Substring(0, k) + aux + input.Substring(k+1);
                j++;
                k--;
            }

            for(int i = input.Length/2; i < input.Length; i++){
                input = input.Substring(0, i) + (char)(input[i]-1) + input.Substring(i+1);
            }

            Console.WriteLine(input);
        }
    } 
}