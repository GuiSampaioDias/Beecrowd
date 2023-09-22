/*
autor: Guilherme Sampaio Dias
exercício: 1078- Tabuada 
plataforma: Beecrowd
data: 20/09/2023
Linguagem: C#

*/
using System;

public class Tabuada
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            int resultado = i * valor;
            Console.WriteLine(i + " x " + valor + " = " + resultado);
        }
    }
}