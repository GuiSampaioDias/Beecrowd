/*
autor: Guilherme Sampaio Dias
exercício: 1017 - Gasto de Combustível
plataforma: Beecrowd
data: 05/09/2023

*/
using System;

class Gasto_de_Combustível
{
    static void Main()
    {
        int horas = int.Parse(Console.ReadLine());
        int speed = int.Parse(Console.ReadLine());

        int distancia = horas * speed;

        double consumo = distancia / 12.0;
        string consumo_f = consumo.ToString("f3");

        Console.WriteLine(consumo_f);
    }
}
