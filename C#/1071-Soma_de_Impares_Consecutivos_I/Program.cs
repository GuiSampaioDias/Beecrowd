/*
autor: Guilherme Sampaio Dias
exercício: 1071- Soma de Ímpares Consecutivos
plataforma: Beecrowd
data: 19/09/2023
Linguagem: C#

*/
using System;

public class SomaDeImpares
{
    public static void Main()
    {
        int maior = 0;
        int menor = 0;
        int val1 = int.Parse(Console.ReadLine());
        int val2 = int.Parse(Console.ReadLine());
        int total = 0;

        if (val1 > val2)
        {
            maior = val1;
            menor = val2;
        }
        else if (val2 > val1)
        {
            maior = val2;
            menor = val1;
        }
        else
        {
            Console.WriteLine(0);
            Environment.Exit(0);
        }
        if (menor % 2 == 0)
            menor += 1;
        else
            menor += 2;
        if (maior % 2 == 0)
            maior -= 1;
        else
            maior -= 2;

        for (int i = menor; i <= maior; i += 2)
            total += i;

        Console.WriteLine(total);


    }
}