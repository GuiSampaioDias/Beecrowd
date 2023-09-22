/*
autor: Guilherme Sampaio Dias
exercício: 1080- Maior Posição
plataforma: Beecrowd
data: 20/09/2023
Linguagem: C#

*/
using System;

public class Maior_Posicao
{
    public static void Main()
    {
        int maior = 0;
        int posicao = 0;
        for (int i = 1; i <= 100; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor > maior)
            {
                maior = valor;
                posicao = i;
            }
        }
        Console.WriteLine(maior + "\n" + posicao);
    }
}