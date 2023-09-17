/*
autor: Guilherme Sampaio Dias
exercício: 1047- Tempo de Jogo com Minutos
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
        int.TryParse(valor[2], out int C);
        int.TryParse(valor[3], out int D);
        int horas;
        int minutos = 0;

        if (A == C)
        {
            if (B == D)
                horas = 24;
            else if (B > D)
            {
                horas = 23;
                minutos = 60 - B + D;
            }
            else
            {
                horas = 0;
                minutos = D - B;
            }
        }
        else if (A > C)
        {
            horas = 24 - A + C;
            if (B > D)
            {
                minutos = 60 - B + D;
                horas -= 1;
            }
            else if (B < D)
                minutos = D - B;
        }
        else
        {
            horas = C - A;
            if (B > D)
            {
                horas -= 1;
                minutos = 60 - B + D;
            }
            else if (B < D)
            {
                horas = C - A;
                minutos = D - B;
            }
        }

        Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
    }
}
