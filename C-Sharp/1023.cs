using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        List<SortedDictionary<int, int>> consumoCidades = new List<SortedDictionary<int, int>>();
        List<double> consumoMedio = new List<double>();
        while(n != 0){
            SortedDictionary<int, int> consumoCidadeAtual = new SortedDictionary<int, int>();
            int consumoTotalCidade = 0;
            int qtdPessoas = 0;
            while(n-- > 0){
                string[] input = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(input[0]);
                int y = Convert.ToInt32(input[1]);

                if(consumoCidadeAtual.ContainsKey(y/x))
                    consumoCidadeAtual[y/x] += x;
                else
                    consumoCidadeAtual.Add(y/x, x);

                qtdPessoas += x;
                consumoTotalCidade += y;
            }
            
            consumoMedio.Add((double)consumoTotalCidade / (double)qtdPessoas);
            consumoCidades.Add(consumoCidadeAtual);
            n = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < consumoCidades.Count; i++){
            Console.WriteLine($"Cidade# {i+1}:");
            int index = 0;
            foreach(var pair in consumoCidades[i]){
                index++;
                Console.Write($"{pair.Value}-{pair.Key}");
                Console.Write((index == consumoCidades[i].Count) ? "\n" : " ");
            }
            
            double formatedNumber = Math.Floor(consumoMedio[i] * 100)/100.0;
            Console.WriteLine($"Consumo medio: {formatedNumber.ToString("F2", CultureInfo.InvariantCulture)} m3.");
            
            if(i+1 != consumoCidades.Count)
                Console.WriteLine();
        }
    } 
}