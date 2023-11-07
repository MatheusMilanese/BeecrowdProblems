using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        while(n != 0){
            string[] line = Console.ReadLine().Split();
            int[] values = new int[n];
            int ans = 0;
            values[0] = int.Parse(line[0]);
            values[1] = int.Parse(line[1]);
            for(int i = 1; i < n-1; i++){
                values[i+1] = int.Parse(line[i+1]);
                if(values[i] > values[i-1] && values[i] > values[i+1]) ans++;
                else if(values[i] < values[i-1] && values[i] < values[i+1]) ans++;
            }
            if(values[0] > values[1] && values[0] > values[n-1]) ans++;
            else if(values[0] < values[1] && values[0] < values[n-1]) ans++;

            if(values[n-1] > values[n-2] && values[n-1] > values[0]) ans++;
            else if(values[n-1] < values[n-2] && values[n-1] < values[0]) ans++;
            Console.WriteLine(ans);


            n = int.Parse(Console.ReadLine());
        }

    }
}