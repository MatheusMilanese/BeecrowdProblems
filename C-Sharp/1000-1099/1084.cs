using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] values = Console.ReadLine().Split(' ');
        int n = int.Parse(values[0]);
        int d = int.Parse(values[1]);
        while(n != 0 && d != 0){
            string s = Console.ReadLine();
            LinkedList<char> ans = new LinkedList<char>();
            int i = 0;
            while(i < n && d > 0){
                if(ans.Count > 0 && ans.Last.Value < s[i]){
                    ans.RemoveLast();
                    d--;
                }
                else{
                    ans.AddLast(s[i++]);
                }
            }
            while(d > 0){
                ans.RemoveLast();
                d--;
            }
            while(ans.Count > 0) {
                Console.Write(ans.First.Value);
                ans.RemoveFirst();
            }
            Console.Write(s.Substring(i));
            Console.WriteLine();
            values = Console.ReadLine().Split(' ');
            n = int.Parse(values[0]);
            d = int.Parse(values[1]);
        }
    }
}