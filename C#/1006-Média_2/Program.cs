/*
 autor: Guilherme Sampaio Dias
 exercício: 1006 - Média 2
 plataforma: Beecrowd
 data: 03/09/2023
 */

using System;

class Programe
{
    static void Main()
    {
        float A = float.Parse(Console.ReadLine());
        float B = float.Parse(Console.ReadLine());
        float C = float.Parse(Console.ReadLine());

        float media = (A * 2 + B * 3 + C * 5) / 10.0f;
        string media_formatada = media.ToString("F1");
        Console.WriteLine("MEDIA = " + media_formatada);

    }
}
