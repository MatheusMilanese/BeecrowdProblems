using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        int distancia = Convert.ToInt32(Console.ReadLine());
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double litros);

        Console.WriteLine($"{(distancia/litros).ToString("F3", CultureInfo.InvariantCulture)} km/l");
    }
}