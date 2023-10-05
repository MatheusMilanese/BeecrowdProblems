using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        int num = int.Parse(Console.ReadLine());

        Dictionary<int, string> calendario = new Dictionary<int, string>(){{1, "January"}, {2, "February"}, {3, "March"}, {4, "April"}, {5, "May"}, {6, "June"}, {7, "July"}, {8, "August"}, {9, "September"}, {10, "October"}, {11, "November"}, {12, "December"}};
        Console.WriteLine(calendario[num]);
    }
}