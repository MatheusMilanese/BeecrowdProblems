using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        Dictionary<int, string> neg = new Dictionary<int, string>(){{-1, "Q3"}, {0, "Eixo X"}, {1, "Q2"}};
        Dictionary<int, string> pos = new Dictionary<int, string>(){{-1, "Q4"}, {0, "Eixo X"}, {1, "Q1"}};
        Dictionary<int, string> zero = new Dictionary<int, string>(){{-1, "Eixo Y"}, {0, "Origem"}, {1, "Eixo Y"}};
        Dictionary<int, Dictionary<int, string>> coord = new Dictionary<int, Dictionary<int, string>>(){{-1, neg}, {0, zero}, {1, pos}};

        string[] input = Console.ReadLine().Split(' ');
        double.TryParse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double x);
        double.TryParse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double y);

        Console.WriteLine(coord[Math.Sign(x)][Math.Sign(y)]);
    }
}