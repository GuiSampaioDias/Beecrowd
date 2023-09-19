/*
autor: Guilherme Sampaio Dias
exercício: 1059- Números pares    
plataforma: Beecrowd
data: 18/09/2023
Linguagem: C#

*/
using System;

public class Numeros_Pares
{
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}