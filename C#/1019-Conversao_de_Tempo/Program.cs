/*
autor: Guilherme Sampaio Dias
exercício: 1019 - Conversão de Tempo
plataforma: Beecrowd
data: 06/09/2023

*/
using System;

class Conversao_de_Tempo
{
    static void Main()
    {
        int segundos = int.Parse(Console.ReadLine());
        int horas = segundos / 3600;

        segundos = segundos - (horas * 3600);
        int minutos = segundos / 60;

        segundos = segundos - (minutos * 60);

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }
}