using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        
        double.TryParse(input[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double n1);
        double.TryParse(input[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double n2);
        double.TryParse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double n3);
        double.TryParse(input[3], NumberStyles.Number, CultureInfo.InvariantCulture, out double n4);

        double media = (n1*2 + n2*3 + n3*4 + n4)/10;
        media = Math.Floor(media*10);
        media /= 10;
        Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
        if(media < 5) Console.WriteLine("Aluno reprovado.");
        else if(media < 7) {
            Console.WriteLine("Aluno em exame.");
            double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double final);
            Console.WriteLine($"Nota do exame: {final.ToString("F1", CultureInfo.InvariantCulture)}");
            media = (media + final) / 2;
            if(media >= 5) Console.WriteLine("Aluno aprovado.");
            else Console.WriteLine("Aluno reprovado.");
            media = Math.Floor(media*10);
            media /= 10;
            Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else Console.WriteLine("Aluno aprovado.");
    }
}