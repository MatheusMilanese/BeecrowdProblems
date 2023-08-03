using System;
using System.Globalization;

class URI {
    static void Main(string[] args){
        int number = Convert.ToInt32(Console.ReadLine());
        int hours = Convert.ToInt32(Console.ReadLine());
        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double moneyHour);
        double salary = hours * moneyHour;
        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}