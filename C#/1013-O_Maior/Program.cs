/*
autor: Guilherme Sampaio Dias
exercício: 1013 - O Maior
plataforma: Beecrowd
data: 05/09/2023

*/
using System;

class Program
{
    static void Main()
    {
        string valores = Console.ReadLine();
        string[] val = valores.Split(' ');
        double.TryParse(val[0], out double val1);
        double.TryParse(val[1], out double val2);
        double.TryParse(val[2], out double val3);
        double maior = val1;

        if (val2 > maior)
            maior = val2;
        if (val3 > maior)
            maior = val3;

        Console.WriteLine(maior + " eh o maior");
    }
}