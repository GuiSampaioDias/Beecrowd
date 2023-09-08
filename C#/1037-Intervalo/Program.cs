/*
autor: Guilherme Sampaio Dias
exercício: 1037 - Intervalo
plataforma: Beecrowd
data: 07/09/2023

*/
using System;

class Intervalo
{
    static void Main()
    {
        float valor = float.Parse(Console.ReadLine());
        if (valor >= 0 && valor <= 25)
            Console.WriteLine("Intervalo [0,25]");

        else if (valor < 0 || valor > 100)
            Console.WriteLine("Fora de intervalo");

        else if (valor <= 50)
            Console.WriteLine("Intervalo (25,50]");

        else if (valor <= 75)
            Console.WriteLine("Intervalo (50,75]");

        else
            Console.WriteLine("(75,100]");
    }
}