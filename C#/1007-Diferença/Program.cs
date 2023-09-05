/*
 * 
 autor: Guilherme Sampaio Dias
 exercício: 1007 - Diferença
 plataforma: Beecrowd
 data: 03/09/2023

 */
using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int resultado = (A * B - C * D);
        Console.WriteLine("DIFERENCA = " + resultado);
    }
}
