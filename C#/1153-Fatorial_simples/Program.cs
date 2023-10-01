/*
autor: Guilherme Sampaio Dias
exercício: 1153- Fatorial Simples   
plataforma: Beecrowd
data: 01/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        int fatorial = 1;
        for (int i = 1; i <= valor; i++)
        {
            fatorial *= i;
        }
        Console.WriteLine(fatorial);

    }
}