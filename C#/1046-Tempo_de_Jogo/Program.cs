/*
autor: Guilherme Sampaio Dias
exercício: 1046- Tempo de Jogo
plataforma: Beecrowd
data: 11/09/2023
Linguagem: C#

*/
using System;

public class Tempo_de_jogo
{
    public static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        int.TryParse(valor[0], out int A);
        int.TryParse(valor[1], out int B);
        int horas;

        if (A == B)
            horas = 24;
        else if (A > B)
            horas = (24 - A) + B;
        else
            horas = B - A;

        Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");

    }
}