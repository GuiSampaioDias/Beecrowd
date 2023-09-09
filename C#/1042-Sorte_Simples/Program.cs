/*
autor: Guilherme Sampaio Dias
exercício: 1042 - Sorte Simples
plataforma: Beecrowd
data: 08/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        double maior;
        double meio;
        double menor;
        string valores = Console.ReadLine();
        string[] val = valores.Split(' ');
        double.TryParse(val[0], out double val1);
        double.TryParse(val[1], out double val2);
        double.TryParse(val[2], out double val3);

        if (val1 > val2 && val1 > val3)
            maior = val1;
        else if (val2 > val1 && val2 > val3)
            maior = val2;
        else
            maior = val3;
        if (val1 < val2 && val2 < val3 || val2 < val1 && val2 > val3)
            meio = val2;
        else if (val2 < val1 && val1 < val3 || val2 > val1 && val1 > val3)
            meio = val1;
        else
            meio = val3;
        if (val1 < val2 && val1 < val3)
            menor = val1;
        else if (val2 < val1 && val2 < val3)
            menor = val2;
        else
            menor = val3;

        Console.WriteLine(menor + "\n" + meio + "\n" + maior);
        Console.WriteLine();
        Console.WriteLine(val1 + "\n" + val2 + "\n" + val3);



    }
}