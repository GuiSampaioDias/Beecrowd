/*
autor: Guilherme Sampaio Dias
exercício: 1117- Validação de Nota
plataforma: Beecrowd
data: 25/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        double total = 0;
        for (int i = 0; i < 2; i++)
        {
            while (true)
            {
                double valor = double.Parse(Console.ReadLine());
                if (valor >= 0 && valor <= 10)
                {
                    total += valor;
                    break;
                }
                else
                    Console.WriteLine("nota invalida");
            }
        }
        double media = total / 2;
        string media_f = media.ToString("f2");
        Console.WriteLine("media = " + media_f);
    }
}