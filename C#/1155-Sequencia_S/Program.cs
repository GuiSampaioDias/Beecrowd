/*
autor: Guilherme Sampaio Dias
exercício: 1155- Sequência S      
plataforma: Beecrowd
data: 10/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        double S = 1;
        double i = 2;
        while (i <= 100)
        {
            S += 1 / i;
            i++;
        }
        Console.WriteLine(S.ToString("f2"));
    }
}