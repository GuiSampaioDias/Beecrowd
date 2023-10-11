/*
autor: Guilherme Sampaio Dias
exercício: 1156- Sequência S II
plataforma: Beecrowd
data: 10/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        double S = 1,
              up = 3,
            down = 2;

        while (up <= 39)
        {
            S += up / down;
            up += 2;
            down *= 2;
        }
        Console.WriteLine(S.ToString("f2"));
    }
}