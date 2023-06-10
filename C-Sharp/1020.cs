using System;

class URI {
    static void Main(string[] args){
        int valor = Convert.ToInt32(Console.ReadLine());

        int[] valorTempos = {365, 30, 1};
        int[] idade = new int[3];

        for(int i = 0; i < 3; i++){
            idade[i] = valor/valorTempos[i];
            valor -= valorTempos[i] * idade[i];
        }

        Console.WriteLine($"{idade[0]} ano(s)\n{idade[1]} mes(es)\n{idade[2]} dia(s)");
        
    }
}