/*
autor: Guilherme Sampaio Dias
exercício: 1065- Pares entre Cinco Números
plataforma: Beecrowd
data: 18/09/2023
Linguagem: C#

*/
using System;

public class Pares
{
    public static void Main()
    {
        int even = 0;
        for (int i = 0; i < 5; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                even += 1;
        }
        Console.WriteLine(even + " valores pares");
    }
}