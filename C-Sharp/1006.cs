using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double notaA);
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double notaB);
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double notaC);

        double media = (notaA*2 + notaB*3 + notaC*5)/10;

        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
    }
}