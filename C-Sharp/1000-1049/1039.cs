using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string line;

        Console.ReadLine();

        while((line = Console.ReadLine() ) != null){
            string[] input = line.Split(' ');
            int r1 = int.Parse(input[0]);
            int x1 = int.Parse(input[1]);
            int y1 = int.Parse(input[2]);
            int r2 = int.Parse(input[3]);
            int x2 = int.Parse(input[4]);
            int y2 = int.Parse(input[5]);
            double dist = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
            if(dist + r2 <= r1) Console.WriteLine("RICO");
            else Console.WriteLine("MORTO");
        }
    }
}