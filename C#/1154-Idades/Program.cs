/*
autor: Guilherme Sampaio Dias
exercício: 1154- Idades             
plataforma: Beecrowd
data: 01/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        double total_notas = 0;
        double quantidade_notas = 0;
        while (true)
        {
            double nota = double.Parse(Console.ReadLine());
            if (nota < 0)
                break;
            quantidade_notas += 1;
            total_notas += nota;
        }
        double media = total_notas / quantidade_notas;
        double media_formatada = Math.Round(media, 2);
        Console.WriteLine(media_formatada.ToString("f2"));
    }
}