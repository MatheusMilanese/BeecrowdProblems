using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        string nome = Console.ReadLine();
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double salary);
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double sales);
        double totalSalary = salary + (sales * 0.15);
        Console.WriteLine($"TOTAL = R$ {totalSalary.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}