using System;

class URI {
    
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int dia1 = int.Parse(input[1]);
        input = Console.ReadLine().Split(' ');
        int hora1 = int.Parse(input[0]);
        int minuto1 = int.Parse(input[2]);
        int segundo1 = int.Parse(input[4]);

        int tempo1 = dia1*86400 + hora1*3600 + minuto1*60 + segundo1;

        input = Console.ReadLine().Split(' ');
        int dia2 = int.Parse(input[1]);
        input = Console.ReadLine().Split(' ');
        int hora2 = int.Parse(input[0]);
        int minuto2 = int.Parse(input[2]);
        int segundo2 = int.Parse(input[4]);

        int tempo2 = dia2*86400 + hora2*3600 + minuto2*60 + segundo2;

        int tempoTotal = tempo2 - tempo1;

        int dia3 = tempoTotal/86400;
        tempoTotal -= dia3*86400;
        int hora3 = tempoTotal/3600;
        tempoTotal -= hora3*3600;
        int minuto3 = tempoTotal/60;
        tempoTotal -= minuto3*60;
        int segundo3 = tempoTotal;

        Console.WriteLine($"{dia3} dia(s)\n{hora3} hora(s)\n{minuto3} minuto(s)\n{segundo3} segundo(s)");
    }
}