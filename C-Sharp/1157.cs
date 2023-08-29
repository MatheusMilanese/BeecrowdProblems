using System;
using System.Collections.Generic;

class URI {
    
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        List<int> divs = new List<int>();
        
        for(int i = 1; i*i <= n; i++){
            if(n%i == 0) {
                divs.Add(i);
                if(n/i != i) divs.Add(n/i);
            }
        }

        divs.Sort();
        for(int i = 0; i < divs.Count; i++) Console.WriteLine(divs[i]);
    }
}