using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double notaA);
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double notaB);

        double media = (notaA*3.5 + notaB*7.5)/11.0;

        Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
    }
}