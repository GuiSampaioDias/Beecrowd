/*
autor: Guilherme Sampaio Dias
exercício: 1074- Par ou Ímpar 
plataforma: Beecrowd
data: 20/09/2023
Linguagem: C#

*/
using System;

public class Par_ou_Impar
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        for (int i = 2; i <= 10000; i++)
        {
            if (i % valor == 2)
                Console.WriteLine(i);
        }
    }
}