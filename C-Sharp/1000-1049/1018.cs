using System;

class URI {
    static void Main(string[] args){
        int valor = Convert.ToInt32(Console.ReadLine());
        int valorInicial = valor;
        int[] valorNotas = {100, 50, 20, 10, 5, 2, 1};

        int[] qtdNotas = new int[7];

        for(int i = 0; i < 7; i++){
            qtdNotas[i] = valor/valorNotas[i];
            valor -= valorNotas[i] * qtdNotas[i];
        }

        Console.WriteLine(valorInicial);
        for(int i = 0; i < 7; i++){
            Console.WriteLine($"{qtdNotas[i]} nota(s) de R$ {valorNotas[i]},00");
        }
    }
}