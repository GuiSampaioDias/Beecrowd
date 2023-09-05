/*
 autor: Guilherme Sampaio Dias
 exercício: 1005 - Média
 plataforma: Beecrowd
 data: 03/09/2023
 */
using System;

class Programe
{
    static void Main()
    {
        float n1 = float.Parse(Console.ReadLine());
        float n2 = float.Parse(Console.ReadLine());

        float media = (n1 * 3.5f  + n2 * 7.5f) / 11.0f;
        string media_formatada = media.ToString("F5");
        Console.WriteLine("MEDIA = " + media_formatada);
    }
}