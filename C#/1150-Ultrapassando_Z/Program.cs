/*
autor: Guilherme Sampaio Dias
exercício: 1150- Ultrapassando o Z
plataforma: Beecrowd
data: 01/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int total = 0;
        int soma = 0;
        int x = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        while (z < x)
            z = int.Parse(Console.ReadLine());

        while (soma < z)
        {
            soma += x;
            total += 1;
            x += 1;

        }
        Console.WriteLine(total);
    }
}