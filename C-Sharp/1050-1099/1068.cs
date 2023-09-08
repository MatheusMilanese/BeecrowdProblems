using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string line = Console.ReadLine();
        while(line != null){
            int opens = 0;
            bool isBalanced = true;
            for(int i = 0; i < line.Length; i++){
                if(line[i] == '(') opens++;
                else if(line[i] == ')'){
                    opens--;
                    isBalanced = isBalanced && opens >= 0;
                }

                if(!isBalanced) break;
            }
            Console.WriteLine(isBalanced && opens==0 ? "correct" : "incorrect");
            line = Console.ReadLine();
        }
    }
}