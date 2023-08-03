using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static void Main(string[] args){
        string input = Console.ReadLine();
        while(input != null){
            uint n1 = Convert.ToUInt32(input.Split(' ')[0]);
            uint n2 = Convert.ToUInt32(input.Split(' ')[1]);
            Console.WriteLine(n1 ^ n2);
            input = Console.ReadLine();
        }
    } 
}