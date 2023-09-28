/*
autor: Guilherme Sampaio Dias
exercício: 1143- Quadrado e ao Cubo
plataforma: Beecrowd
data: 27/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            double quadrado = Math.Pow(i, 2);
            double cubo = Math.Pow(i, 3);
            Console.WriteLine(i + " " + quadrado + " " + cubo);
        }
    }
}