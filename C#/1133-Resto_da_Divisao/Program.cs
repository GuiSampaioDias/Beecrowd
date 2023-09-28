/*
autor: Guilherme Sampaio Dias
exercício: 1133- Resto da divisão
plataforma: Beecrowd
data: 2709/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
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


        for (int i = inicio + 1; i < fim; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
                Console.WriteLine(i);
        }
    }
}