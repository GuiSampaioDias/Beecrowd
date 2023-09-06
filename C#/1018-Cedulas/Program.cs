/*
autor: Guilherme Sampaio Dias
exercício: 1018 - Cédulas
plataforma: Beecrowd
data: 05/09/2023

*/
using System;

class Cedula
{
    static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);
        int notas = valor / 100;
        Console.WriteLine(notas + " nota(s) de R$ 100,00");
        valor = valor % 100;
        notas = valor / 50;
        Console.WriteLine(notas + " nota(s) de R$ 50,00");
        valor = valor % 50;
        notas = valor / 20;
        Console.WriteLine(notas + " nota(s) de R$ 20,00");
        valor = valor % 20;
        notas = valor / 10;
        Console.WriteLine(notas + " nota(s) de R$ 10,00");
        valor = valor % 10;
        notas = valor / 5;
        Console.WriteLine(notas + " nota(s) de R$ 5,00");
        valor = valor % 5;
        notas = valor / 2;
        Console.WriteLine(notas + " nota(s) de R$ 2,00");
        valor = valor % 2;
        notas = valor / 1;
        Console.WriteLine(notas + " nota(s) de R$ 1,00");
    }
}
