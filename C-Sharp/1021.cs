using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double valor);

        double[] valorDinheiro = {100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.1, 0.05, 0.01};
        int[] qtdDinheiros = new int[12];

        for(int i = 0; i < 12; i++){
            qtdDinheiros[i] = (int)(valor/valorDinheiro[i]);
            valor -= (double)(qtdDinheiros[i] * valorDinheiro[i]);
            valor = Math.Round(valor, 2);
        }

        Console.WriteLine("NOTAS:");
        for(int i = 0; i < 6; i++){
            Console.WriteLine($"{qtdDinheiros[i]} nota(s) de R$ {valorDinheiro[i].ToString("F2", CultureInfo.InvariantCulture)}");
        }
        Console.WriteLine("MOEDAS:");
        for(int i = 6; i < 12; i++){
            Console.WriteLine($"{qtdDinheiros[i]} moeda(s) de R$ {valorDinheiro[i].ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}