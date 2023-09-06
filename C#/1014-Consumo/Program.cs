/*
autor: Guilherme Sampaio Dias
exercício: 1014 - Consulmo
plataforma: Beecrowd
data: 05/09/2023

*/
using System;

class Program
{
    static void Main()
    {
        int kms = int.Parse(Console.ReadLine());
        double litros = double.Parse(Console.ReadLine());
        double consumo = kms / litros;
        string consumo_f = consumo.ToString("f3");

        Console.WriteLine(consumo_f + " km/l");
    }
}