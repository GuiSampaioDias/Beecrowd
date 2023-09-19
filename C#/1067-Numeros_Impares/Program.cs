/*
autor: Guilherme Sampaio Dias
exercício: 1067 Números Ímpares
plataforma: Beecrowd
data: 18/09/2023
Linguagem: C#

*/
using System;

public class Pares_Impares
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        for (int i = 1; i <= valor; i += 2)
            Console.WriteLine(i);
    }
}