/*
autor: Guilherme Sampaio Dias
exercício: 1132- Multiplos de 13
plataforma: Beecrowd
data: 2709/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int soma = 0;
        int val1 = int.Parse(Console.ReadLine());
        int val2 = int.Parse(Console.ReadLine());
        int inicio;
        int fim;
        if (val1 < val2)
        {
            inicio = val1;
            fim = val2;
        }
        else
        {
            inicio = val2;
            fim = val1;
        }


        for (int i = inicio; i <= fim; i++)
        {
            if (i % 13 != 0)
                soma += i;
        }
        Console.WriteLine(soma);
    }
}