using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        List<int> v = new List<int>(){int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2])};
        List<int> w = new List<int>(){v[0], v[1], v[2]};
        v.Sort();

        Console.WriteLine($"{v[0]}\n{v[1]}\n{v[2]}\n");

        Console.WriteLine($"{w[0]}\n{w[1]}\n{w[2]}");
    }
}