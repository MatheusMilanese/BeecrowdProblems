using System;

class URI {
    static void Main(string[] args){
        int valor = Convert.ToInt32(Console.ReadLine());

        int[] valorHoras = {3600, 60, 1};
        int[] hora = new int[3];

        for(int i = 0; i < 3; i++){
            hora[i] = valor/valorHoras[i];
            valor -= valorHoras[i] * hora[i];
        }

        Console.WriteLine($"{hora[0]}:{hora[1]}:{hora[2]}");
        
    }
}