using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        while(n-- > 0){
            string line = Console.ReadLine();
            int diamonds = 0;
            int pieces = 0;
            for(int i = 0; i < line.Length; i++){
                if(line[i] == '<') pieces++;
                else if(line[i] == '>' && pieces > 0){
                    pieces--;
                    diamonds++;
                }
            }
            Console.WriteLine(diamonds);
        }
    }
}