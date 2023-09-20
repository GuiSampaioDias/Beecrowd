/*
autor: Guilherme Sampaio Dias
exercício: 1073- Quadrado de Pares
plataforma: Beecrowd
data: 19/09/2023
Linguagem: C#

*/
using System;

public class Quadrado_de_Pares
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        if (valor % 2 == 1)
            valor -= 1;
        for (int i = 2; i <= valor; i += 2)
        {
            double quadrado = Math.Pow(i, 2);
            Console.WriteLine(i + "^2 = " + quadrado);
        }
    }
}