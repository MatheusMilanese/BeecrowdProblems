using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        string[] input = Console.ReadLine().Split(' ');

        int cod1 = Convert.ToInt32(input[0]);
        int qtd1 = Convert.ToInt32(input[1]);
        double.TryParse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double price1);
        
        input = Console.ReadLine().Split(' ');
        int cod2 = Convert.ToInt32(input[0]);
        int qtd2 = Convert.ToInt32(input[1]);
        double.TryParse(input[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double price2);

        double totalCost = (qtd1 * price1) + (qtd2 * price2);

        Console.WriteLine($"VALOR A PAGAR: R$ {totalCost.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}