using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        int tempo = Convert.ToInt32(Console.ReadLine());
        int velocidade = Convert.ToInt32(Console.ReadLine());

        int distancia = tempo*velocidade;
        double qtdCombustivel = distancia/12.0;

        Console.WriteLine(qtdCombustivel.ToString("F3", CultureInfo.InvariantCulture));
    }
}