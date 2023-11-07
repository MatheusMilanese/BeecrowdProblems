using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string[] line = Console.ReadLine().Split();
        int[] values = new int[4]{int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]), int.Parse(line[3])};
        while(values[0] != 0 || values[0] != 0 || values[0] != 0 || values[0] != 0){
            //Mesma posição
            if(values[0] == values[2] && values[1] == values[3]) Console.WriteLine(0);
            
            //verificando horizontal e vertical
            else if(values[0] - values[2] == 0 || values[1] - values[3] == 0) Console.WriteLine(1);

            //verificando diagonal
            else if(Math.Abs(values[0] - values[2]) == Math.Abs(values[1] - values[3])) Console.WriteLine(1);

            //Qualquer outro caso são dois movimentos
            else Console.WriteLine(2);

            line = Console.ReadLine().Split();
            values = new int[4]{int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]), int.Parse(line[3])};
        }

    }
}