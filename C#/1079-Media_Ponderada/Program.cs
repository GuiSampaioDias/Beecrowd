/*
autor: Guilherme Sampaio Dias
exercício: 1079- Médias Ponderadas
plataforma: Beecrowd
data: 20/09/2023
Linguagem: C#

*/
using System;

public class Tabuada
{
    public static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantidade; i++)
        {
            string valores = Console.ReadLine();
            string[] valor = valores.Split(' ');

            // Transformar os  valores em double
            double.TryParse(valor[0], out double value1);
            double.TryParse(valor[1], out double value2);
            double.TryParse(valor[2], out double value3);

            // Fazer a média dos 3 valore
            double media = (value1 * 2 + value2 * 3 + value3 * 5) / 10;
            string media_f = media.ToString("f1");

            Console.WriteLine(media_f);
        }
    }
}