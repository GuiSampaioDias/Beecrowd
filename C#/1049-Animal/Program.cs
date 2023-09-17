/*
autor: Guilherme Sampaio Dias
exercício: 1049- Animal     
plataforma: Beecrowd
data: 15/09/2023
Linguagem: C#

*/
using System;

public class Animal
{
    public static void Main()
    {
        string coluna = Console.ReadLine();
        string animal = Console.ReadLine();
        string organismo = Console.ReadLine();

        if (coluna == "vertebrado")
        {
            if (animal == "ave")
            {
                if (organismo == "carnivoro")
                    Console.WriteLine("aguia");
                else
                    Console.WriteLine("pomba");
            }
            else
            {
                if (organismo == "onivoro")
                    Console.WriteLine("homem");
                else
                    Console.WriteLine("vaca");
            }
        }
        else
        {
            if (animal == "inseto")
            {
                if (organismo == "hematofago")
                    Console.WriteLine("pulga");
                else
                    Console.WriteLine("lagarta");
            }
            else
            {
                if (organismo == "hematofago")
                    Console.WriteLine("sanguessuga");
                else
                    Console.WriteLine("minhoca");
            }
        }
    }
}
