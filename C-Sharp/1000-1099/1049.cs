using System;
using System.Collections.Generic;
using System.Globalization;

class URI {
    public static void Main(string[] args) {
        string line1 = Console.ReadLine();
        string line2 = Console.ReadLine();
        string line3 = Console.ReadLine();

            
            if(line1 == "vertebrado"){
                if(line2 == "ave"){
                    if(line3 == "carnivoro") Console.WriteLine("aguia");
                    else Console.WriteLine("pomba");
                }
                else{
                    if(line3 == "onivoro") Console.WriteLine("homem");
                    else Console.WriteLine("vaca");
                }
            }
            else if(line2 == "inseto"){
                if(line3 == "hematofago") Console.WriteLine("pulga");
                else Console.WriteLine("lagarta");
            }
            else if(line3 == "hematofago") Console.WriteLine("sanguessuga");
            else Console.WriteLine("minhoca");
            
    }
}