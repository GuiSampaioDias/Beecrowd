/*
autor: Guilherme Sampaio Dias
exercício: 1070- Seis Números Ímpares
plataforma: Beecrowd
data: 19/09/2023
Linguagem: C#

*/
using System;

public class Seis_numeros_impares
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        if (valor % 2 == 0)
            valor += 1;
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(valor);
            valor += 2;
        }

    }
}