using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out double x);
        double ans = x * x * 3.14159;
        Console.WriteLine($"A=" + ans.ToString("F4", CultureInfo.InvariantCulture));

    }

}