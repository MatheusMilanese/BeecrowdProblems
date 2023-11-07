using System;
using System.Collections.Generic;
using System.Globalization;

// A solução para este problema se baseia na "ruína do jogador"
class URI { 
    public static void Main(string[] args) {
        while(true){
            string[] line = Console.ReadLine().Split();
            
            double av1 = double.Parse(line[0]);
            double av2 = double.Parse(line[1]);
            double at = double.Parse(line[2]);
            double d = double.Parse(line[3]);

            if(av1 == 0 && av2 == 0 && at == 0 && d == 0) break;

            
            int qtd1 = 1;
            while((av1 -= d) > 0) qtd1++;

            int qtd2 = 1;
            while((av2 -= d) > 0) qtd2++;

            double ans;
            if(at == 3){
                ans = (double)(qtd1 / (double)(qtd1 + qtd2))*100;
            }
            else{
                double dado = 1.0 - (6.0-at)/6;
                dado = (1.0-dado)/dado;
                double a = 1-Math.Pow(dado, qtd1);
                double b = 1-Math.Pow(dado, (double)qtd1+qtd2);
                ans = a/b*100;
            }
            
            Console.WriteLine(ans.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}