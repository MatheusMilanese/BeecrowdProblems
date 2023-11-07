using System;
using System.Collections.Generic;
using System.Globalization;

class URI { 
    public static void Main(string[] args) {
        double i = 0, j = 1;
        while(i <= 2) {
            string s1 = i.ToString("F1", CultureInfo.InvariantCulture);
            string s2 = j.ToString("F1", CultureInfo.InvariantCulture);
            string s3 = (j+1).ToString("F1", CultureInfo.InvariantCulture);
            string s4 = (j+2).ToString("F1", CultureInfo.InvariantCulture);
            if(s1[2] != '0') Console.WriteLine($"I={s1} J={s2}\nI={s1} J={s3}\nI={s1} J={s4}");
            else Console.WriteLine($"I={s1[0]} J={s2[0]}\nI={s1[0]} J={s3[0]}\nI={s1[0]} J={s4[0]}");
            i += 0.2;
            j += 0.2;
        }
    }
}