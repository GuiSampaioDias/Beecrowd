/*
autor: Guilherme Sampaio Dias
exercício: 1060- Números Positivos    
plataforma: Beecrowd
data: 18/09/2023
Linguagem: C#

*/
using System;

public class Numeros_Pares
{
    public static void Main()
    {
        int positivos = 0;
        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
                positivos += 1;
        }
        Console.WriteLine(positivos + " valores positivos");
    }
}